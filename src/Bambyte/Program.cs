using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Bambyte.Gifs;
using Bambyte.GiphyWrapper;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;

namespace Bambyte
{
    // This whole class is taken from the official discord.net documentation
    // It originaly had more comments and annotations
    // https://docs.stillu.cc/guides/getting_started/samples/first-bot/structure.cs
    public class Program
    {
        public static void Main(string[] args)
        {
            new Program().MainAsync().GetAwaiter().GetResult();
        }

        private readonly DiscordSocketClient client;
        private readonly CommandService commandService;
        private readonly IServiceProvider services;

        private Program()
        {
            client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Info,
            });

            commandService = new CommandService(new CommandServiceConfig
            {
                LogLevel = LogSeverity.Info,
                CaseSensitiveCommands = false,
            });

            client.Log += Log;
            commandService.Log += Log;

            services = ConfigureServices();
        }

        // Build DI
        private static IServiceProvider ConfigureServices()
        {
            var map = new ServiceCollection()
                .AddSingleton(new GiphyClient(File.ReadAllText("TokenGiphy.txt").Trim()))
                .AddSingleton(new Random());

            return map.BuildServiceProvider(true);
        }

        private static Task Log(LogMessage message)
        {
            switch (message.Severity)
            {
                case LogSeverity.Critical:
                case LogSeverity.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case LogSeverity.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogSeverity.Info:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogSeverity.Verbose:
                case LogSeverity.Debug:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }

            Console.WriteLine($"{DateTime.Now,-19} [{message.Severity,8}] {message.Source}: {message.Message} {message.Exception}");
            Console.ResetColor();

            return Task.CompletedTask;
        }

        private async Task MainAsync()
        {
            await InitCommands();

            await client.LoginAsync(TokenType.Bot, File.ReadAllText("TokenDiscord.txt").Trim());
            await client.StartAsync();

            await Task.Delay(Timeout.Infinite);
        }

        private async Task InitCommands()
        {
            // make sure gifs is loaded
            Assembly.Load("Bambyte.Gifs");

            // Register all commands in assemblies
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                await commandService.AddModulesAsync(assembly, services);
            }

            // BaseDiscordClient has a ton of other events to bind to
            client.MessageReceived += HandleCommandAsync;
        }

        private async Task HandleCommandAsync(SocketMessage arg)
        {
            if (arg is not SocketUserMessage msg)
            {
                return;
            }

            if (msg.Author.Id == client.CurrentUser.Id || msg.Author.IsBot)
            {
                return;
            }

            await HandleSpecialCases(msg);
            await HandleCommands(msg);
        }

        private async Task HandleSpecialCases(SocketUserMessage msg)
        {
            await PhpJeTaimes(msg);
        }

        private async Task PhpJeTaimes(SocketUserMessage msg)
        {
            var heartEmojis = new string[] { "😍", "😘", "🥰", "❤" };
            if (msg.Content.ToLower().Contains("php"))
            {
                var random = services.GetRequiredService<Random>();
                var emojiIndex = random.Next(0, heartEmojis.Length);
                await msg.AddReactionAsync(new Emoji(heartEmojis[emojiIndex]));
            }
        }

        private async Task HandleCommands(SocketUserMessage msg)
        {
            // Create a number to track where the prefix ends and the command begins
            int pos = 0;
            if (msg.HasStringPrefix("bb", ref pos) || msg.HasMentionPrefix(client.CurrentUser, ref pos))
            {
                // Create a Command Context.
                var context = new SocketCommandContext(client, msg);

                // Execute the command. (result does not indicate a return value,
                // rather an object stating if the command executed successfully).
                var result = await commandService.ExecuteAsync(context, pos, services);

                // Uncomment the following lines if you want the bot
                // to send a message if it failed.
                // This does not catch errors from commands with 'RunMode.Async',
                // subscribe a handler for '_commands.CommandExecuted' to see those.
                if (!result.IsSuccess && result.Error == CommandError.UnknownCommand)
                {
                    await Log(new LogMessage(LogSeverity.Warning, string.Empty, $"Unknown Command {msg}"));
                }
            }
        }
    }
}
