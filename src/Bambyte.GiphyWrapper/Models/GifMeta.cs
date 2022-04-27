using Newtonsoft.Json;

namespace Bambyte.GiphyWrapper.Models
{
    public class GifMeta
    {
        /// <summary>
        /// HTTP Response Message.
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// HTTP Response Code.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// A unique ID paired with this response from the API.
        /// </summary>
        [JsonProperty("response_id")]
        public string ResponseId { get; set; }
    }
}
