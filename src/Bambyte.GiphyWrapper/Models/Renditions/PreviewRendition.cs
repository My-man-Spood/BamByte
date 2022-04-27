using Newtonsoft.Json;

namespace Bambyte.GiphyWrapper.Models.Renditions
{
    public class PreviewRendition
    {
        /// <summary>
        /// The URL for this GIF in .MP4 format.
        /// </summary>
        [JsonProperty("mp4")]
        public string Mp4 { get; set; }

        /// <summary>
        /// The size of this file in bytes.
        /// </summary>
        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }

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
    }
}
