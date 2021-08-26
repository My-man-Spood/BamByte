using System;
using System.Threading.Tasks;
using GiphyDotNet.Manager;
using GiphyDotNet.Model.Parameters;

namespace Bambyte.Gifs
{
    public class GiphyWrapper
    {
        private readonly Giphy giphy;

        public GiphyWrapper(string token)
        {
            giphy = new Giphy(token);
        }

        public async Task<string> SearchRandomGif(string query, bool safeMode)
        {
            var search = new RandomParameter
            {
                Tag = query,
                Rating = safeMode ? Rating.Pg : Rating.R,
            };

            var result = await giphy.RandomGif(search);

            return result.Data.ImageUrl;
        }

        public string NotFound()
        {
            return "https://media.giphy.com/media/2vlC9FMLSmqGs/giphy.gif";
        }
    }
}
