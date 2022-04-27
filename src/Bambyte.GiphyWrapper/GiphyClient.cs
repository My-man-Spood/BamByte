using System;
using System.Threading;
using System.Threading.Tasks;
using Bambyte.GiphyWrapper.Models;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace Bambyte.GiphyWrapper
{
    public class GiphyClient : IDisposable
    {
        private RestClient client;
        private string apiKey;

        public GiphyClient(string apiKey)
        {
            this.apiKey = apiKey;
            client = new RestClient("https://api.giphy.com/v1/gifs");
            client.UseNewtonsoftJson();
        }

        /// <summary>
        /// GIPHY Random lets you add some weirdness to the conversation by returning a single random GIF or Sticker related to the word or phrase entered. If no tag is specified, the GIF or Sticker returned is completely random.
        /// </summary>
        public async Task<SingleResultResponse> RandomAsync(string tag = "", string rating = "", string randomId = "", CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("random");
            request.AddQueryParameter("api_key", apiKey);
            request.AddQueryParameter("tag", tag);
            request.AddQueryParameter("rating", rating);
            request.AddQueryParameter("random_id", randomId);

            return await client.GetAsync<SingleResultResponse>(request, cancellationToken);
        }

        /// <summary>
        /// GIPHY Random lets you add some weirdness to the conversation by returning a single random GIF or Sticker related to the word or phrase entered. If no tag is specified, the GIF or Sticker returned is completely random.
        /// </summary>
        public SingleResultResponse Random(string tag = "", string rating = "", string randomId = "")
        {
            return RandomAsync(tag, rating, randomId).Result;
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
