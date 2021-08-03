using System.Threading.Tasks;
using Bambyte.Gifs;
using Discord;
using Discord.Commands;

namespace Bambyte.Modules
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
            var url = await giphyWrapper.SearchRandomGif(gifName, true);
            var embed = new EmbedBuilder
            {
                Title = gifName,
                ImageUrl = url,
            }.Build();
            await ReplyAsync(embed: embed);
        }
    }
}
