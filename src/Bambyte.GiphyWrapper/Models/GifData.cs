using System;
using Newtonsoft.Json;

namespace Bambyte.GiphyWrapper.Models
{
    public class GifData
    {
        /// <summary>
        /// By default, this is almost always GIF.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// This GIF's unique ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The unique slug used in this GIF's URL
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// The unique URL for this GIF
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// The unique bit.ly URL for this GIF
        /// </summary>
        [JsonProperty("bitly_url")]
        public string BitlyUrl { get; set; }

        /// <summary>
        /// A URL used for embedding this GIF
        /// </summary>
        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }

        /// <summary>
        /// The username this GIF is attached to, if applicable
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// The page on which this GIF was found
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// The MPAA-style rating for this content. Examples include Y, G, PG, PG-13 and R
        /// </summary>
        [JsonProperty("rating")]
        public string Rating { get; set; }

        /// <summary>
        /// Currently unused
        /// </summary>
        [JsonProperty("content_url")]
        public string ContentUrl { get; set; }

        /// <summary>
        /// An object containing data about the user associated with this GIF, if applicable.
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }

        /// <summary>
        /// The top level domain of the source URL.
        /// </summary>
        [JsonProperty("source_tld")]
        public string SourceTld { get; set; }

        /// <summary>
        /// The URL of the webpage on which this GIF was found.
        /// </summary>
        [JsonProperty("source_post_url")]
        public string SourcePostUrl { get; set; }

        /// <summary>
        /// The date on which this GIF was last updated.
        /// </summary>
        [JsonProperty("update_datetime")]
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// The date this GIF was added to the GIPHY database.
        /// </summary>
        [JsonProperty("created_datetime")]
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// The creation or upload date from this GIF's source.
        /// </summary>
        [JsonProperty("import_datetime")]
        public DateTime ImportDateTime { get; set; }

        /// <summary>
        /// The date on which this gif was marked trending, if applicable.
        /// </summary>
        [JsonProperty("trendind_datetime")]
        public DateTime TrendingDateTime { get; set; }

        /// <summary>
        /// An object containing data for various available formats and sizes of this GIF.
        /// </summary>
        [JsonProperty("images")]
        public Renditions.Renditions Images { get; set; }

        /// <summary>
        /// The title that appears on giphy.com for this GIF.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
