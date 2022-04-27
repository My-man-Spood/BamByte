using Newtonsoft.Json;

namespace Bambyte.GiphyWrapper.Models.Renditions
{
    public class DownSizedRendition
    {
        /// <summary>
        /// The publicly-accessible direct URL for this GIF.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// The width of this GIF in pixels.
        /// </summary>
        [JsonProperty("width")]
        public string Width { get; set; }

        /// <summary>
        /// The height of this GIF in pixels.
        /// </summary>
        [JsonProperty("height")]
        public string Height { get; set; }

        /// <summary>
        /// The size of this GIF in bytes.
        /// </summary>
        [JsonProperty("size")]
        public string Size { get; set; }
    }
}
