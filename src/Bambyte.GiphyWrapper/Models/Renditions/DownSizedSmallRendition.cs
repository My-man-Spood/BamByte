using Newtonsoft.Json;

namespace Bambyte.GiphyWrapper.Models.Renditions
{
    public class DownSizedSmallRendition
    {
        /// <summary>
        /// The publicly-accessible direct URL for this GIF.
        /// </summary>
        [JsonProperty("mp4")]
        public string Mp4 { get; set; }

        /// <summary>
        /// The width of this file in pixels.
        /// </summary>
        [JsonProperty("width")]
        public string Width { get; set; }

        /// <summary>
        /// The height of this file in pixels.
        /// </summary>
        [JsonProperty("height")]
        public string Height { get; set; }

        /// <summary>
        /// The size of this file in bytes.
        /// </summary>
        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }
    }
}
