using Newtonsoft.Json;

namespace Bambyte.GiphyWrapper.Models.Renditions
{
    public class OriginalRendition
    {
        /// <summary>
        /// The height of this GIF in pixels.
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

        /// <summary>
        /// The number of frames in this GIF.
        /// </summary>
        [JsonProperty("frames")]
        public int Frames { get; set; }

        /// <summary>
        /// The URL for this GIF in .MP4 format.
        /// </summary>
        [JsonProperty("mp4")]
        public string Mp4 { get; set; }

        /// <summary>
        /// The size in bytes of the .MP4 file corresponding to this GIF.
        /// </summary>
        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }

        /// <summary>
        /// The URL for this GIF in .webp format.
        /// </summary>
        [JsonProperty("webp")]
        public string Webp { get; set; }

        /// <summary>
        /// The size in bytes of the .webp file corresponding to this GIF.
        /// </summary>
        [JsonProperty("webp_size")]
        public string WebpSize { get; set; }
    }
}
