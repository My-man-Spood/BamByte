using Newtonsoft.Json;

namespace Bambyte.GiphyWrapper.Models.Renditions
{
    public class LoopingRendition
    {
        /// <summary>
        /// The URL for this GIF in .MP4 format.
        /// </summary>
        [JsonProperty("mp4")]
        public string Mp4 { get; set; }
    }
}
