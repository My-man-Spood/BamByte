using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bambyte.GiphyWrapper.Models
{
    public class MultiResultResponse
    {
        [JsonProperty("data")]
        public List<GifData> Data { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("meta")]
        public GifMeta Meta { get; set; }
    }
}
