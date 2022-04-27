using System;
using System.Threading.Tasks;
using Bambyte.GiphyWrapper;
using Bambyte.GiphyWrapper.Models;
using Discord;
using Discord.Commands;

namespace Bambyte.Gifs.Modules
{
    public class GifModule : ModuleBase<SocketCommandContext>
    {
        private const string LostJohnTravolta = "https://media.giphy.com/media/2vlC9FMLSmqGs/giphy.gif";
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
                await ReplyAsync(message: LostJohnTravolta);
            }

            await ReplyAsync(embed: new EmbedBuilder().BuildFromGifData(response.Data, gifName));
        }
    }
}
