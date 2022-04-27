using Newtonsoft.Json;

namespace Bambyte.GiphyWrapper.Models.Renditions
{
    public class Renditions
    {
        /// <summary>
        /// Data on versions of this GIF with a fixed height of 200 pixels. Good for mobile use.
        /// </summary>
        [JsonProperty("fixed_height")]
        public StandardRendition FixedHeight { get; set; }

        /// <summary>
        /// Data on a static image of this GIF with a fixed height of 200 pixels.
        /// </summary>
        [JsonProperty("fixed_height_still")]
        public StillRendition FixedHeightStill { get; set; }

        /// <summary>
        /// Data on versions of this GIF with a fixed height of 200 pixels and the number of frames reduced to 6.
        /// </summary>
        [JsonProperty("fixed_height_downsampled")]
        public DownSampledRendition FixedHeightDownsampled { get; set; }

        /// <summary>
        /// Data on versions of this GIF with a fixed width of 200 pixels. Good for mobile use.
        /// </summary>
        [JsonProperty("fixed_width")]
        public StandardRendition FixedWidth { get; set; }

        /// <summary>
        /// Data on a static image of this GIF with a fixed width of 200 pixels.
        /// </summary>
        [JsonProperty("fixed_width_still")]
        public StillRendition FixedWidthStill { get; set; }

        /// <summary>
        /// Data on versions of this GIF with a fixed width of 200 pixels and the number of frames reduced to 6.
        /// </summary>
        [JsonProperty("fixed_width_downsampled")]
        public DownSampledRendition FixedWidthDownSampled { get; set; }

        /// <summary>
        /// Data on versions of this GIF with a fixed height of 100 pixels. Good for mobile keyboards.
        /// </summary>
        [JsonProperty("fixed_height_small")]
        public StandardRendition FixedHeightSmall { get; set; }

        /// <summary>
        /// Data on a static image of this GIF with a fixed height of 100 pixels.
        /// </summary>
        [JsonProperty("fixed_height_small_still")]
        public StillRendition FixedHeightSmallStill { get; set; }

        /// <summary>
        /// Data on versions of this GIF with a fixed width of 100 pixels. Good for mobile keyboards.
        /// </summary>
        [JsonProperty("fixed_width_small")]
        public StandardRendition FixedWidthSmall { get; set; }

        /// <summary>
        /// Data on a static image of this GIF with a fixed width of 100 pixels.
        /// </summary>
        [JsonProperty("fixed_width_small_still")]
        public StillRendition FixedWidthSmallStill { get; set; }

        /// <summary>
        /// Data on a version of this GIF downsized to be under 2mb.
        /// </summary>
        [JsonProperty("downsized")]
        public DownSizedRendition DownSized { get; set; }

        /// <summary>
        /// Data on a static preview image of the downsized version of this GIF.
        /// </summary>
        [JsonProperty("downsized_still")]
        public StillRendition DownSizedStill { get; set; }

        /// <summary>
        /// Data on a version of this GIF downsized to be under 8mb.
        /// </summary>
        [JsonProperty("downsized_large")]
        public DownSizedRendition DownSizedLarge { get; set; }

        /// <summary>
        /// Data on a version of this GIF downsized to be under 5mb.
        /// </summary>
        [JsonProperty("downsized_medium")]
        public DownSizedRendition DownSizedMedium { get; set; }

        /// <summary>
        /// Data on a version of this GIF downsized to be under 200kb.
        /// </summary>
        [JsonProperty("downsized_small")]
        public DownSizedSmallRendition DownSizedSmall { get; set; }

        /// <summary>
        /// Data on the original version of this GIF. Good for desktop use.
        /// </summary>
        [JsonProperty("original")]
        public OriginalRendition Original { get; set; }

        /// <summary>
        /// Data on a static preview image of the original GIF.
        /// </summary>
        [JsonProperty("original_still")]
        public StillRendition OriginalStill { get; set; }

        /// <summary>
        /// Data on the 15 second version of the GIF looping.
        /// </summary>
        [JsonProperty("looping")]
        public LoopingRendition Looping { get; set; }

        /// <summary>
        /// Data on a version of this GIF in .MP4 format limited to 50kb that displays the first 1-2 seconds of the GIF.
        /// </summary>
        [JsonProperty("preview")]
        public PreviewRendition Preview { get; set; }

        /// <summary>
        /// Data on a version of this GIF limited to 50kb that displays the first 1-2 seconds of the GIF.
        /// </summary>
        [JsonProperty("preview_gif")]
        public PreviewGifRendition PreviewGif { get; set; }
    }
}
