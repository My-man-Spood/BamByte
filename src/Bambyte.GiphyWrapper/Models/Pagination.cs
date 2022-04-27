using Newtonsoft.Json;

namespace Bambyte.GiphyWrapper.Models
{
    public class Pagination
    {
        /// <summary>
        /// Position in pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Total number of items available (not returned on every endpoint).
        /// </summary>
        [JsonProperty("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Total number of items returned.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
