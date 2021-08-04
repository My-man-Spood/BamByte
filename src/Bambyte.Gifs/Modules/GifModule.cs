using System;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace Bambyte.Gifs.Modules
{
    public class GifModule : ModuleBase<SocketCommandContext>
    {
        private readonly GiphyWrapper giphyWrapper;

        public GifModule(GiphyWrapper giphyWrapper)
        {
            this.giphyWrapper = giphyWrapper;
        }

        [Command("gif")]
        public async Task SendGif([Remainder]string gifName)
        {
            string url;

            try
            {
                url = await giphyWrapper.SearchRandomGif(gifName, true);
            }
            catch (Exception)
            {
                url = giphyWrapper.NotFound();
                gifName = "404";
            }

            var embed = new EmbedBuilder
            {
                Title = gifName,
                ImageUrl = url,
            }.Build();
            await ReplyAsync(embed: embed);
        }
    }
}
