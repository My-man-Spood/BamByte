using System;
using System.Threading.Tasks;
using Bambyte.GiphyWrapper;
using Bambyte.GiphyWrapper.Models;
using Bambyte.GiphyWrapper.Models.Renditions;
using Discord;
using Discord.Commands;

namespace Bambyte.Gifs.Modules
{
    public class GifModule : ModuleBase<SocketCommandContext>
    {
        private readonly GiphyClient giphyClient;

        public GifModule(GiphyClient giphyWrapper)
        {
            this.giphyClient = giphyWrapper;
        }

        [Command("gif")]
        public async Task SendGif([Remainder]string gifName)
        {
            SingleResultResponse response = null;

            try
            {
                response = await giphyClient.RandomAsync(tag: gifName, rating: GiphyRatings.PG);
            }
            catch (Exception e)
            {
                await ReplyAsync(message: "https://media.giphy.com/media/2vlC9FMLSmqGs/giphy.gif");
            }

            var embed = new EmbedBuilder()
                .WithAuthor(new EmbedAuthorBuilder()
                    .WithName(response?.Data?.User?.DisplayName ?? response?.Data?.User?.Username ?? "Giphy")
                    .WithUrl(response?.Data?.User?.ProfileUrl ?? string.Empty)
                    .WithIconUrl(response?.Data?.User?.AvatarUrl ?? "https://cdn.iconscout.com/icon/free/png-256/giphy-461796.png"))
                .WithImageUrl(GetLargestDownsizedUrl(response?.Data?.Images) ?? "https://media.giphy.com/media/2vlC9FMLSmqGs/giphy.gif")
                .WithTitle(response?.Data?.Title ?? gifName)
                .WithDescription($"\"{gifName}\" via Giphy")
                .Build();

            await ReplyAsync(embed: embed);
        }

        private string GetLargestDownsizedUrl(Renditions renditions)
        {
            return renditions.DownSizedLarge?.Url ??
                renditions.DownSizedMedium?.Url ??
                renditions.DownSized?.Url;
        }
    }
}
