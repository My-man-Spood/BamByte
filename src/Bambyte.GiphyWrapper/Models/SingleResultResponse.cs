using Newtonsoft.Json;

namespace Bambyte.GiphyWrapper.Models
{
    public class SingleResultResponse
    {
        [JsonProperty("data")]
        public GifData Data { get; set; }

        [JsonProperty("meta")]
        public GifMeta Meta { get; set; }
    }
}
