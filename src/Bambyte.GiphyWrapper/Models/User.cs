using Newtonsoft.Json;

namespace Bambyte.GiphyWrapper.Models
{
    public class User
    {
        /// <summary>
        /// The URL for this user's avatar image.
        /// </summary>
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// The URL for the banner image that appears atop this user's profile page.
        /// </summary>
        [JsonProperty("banner_url")]
        public string BannerUrl { get; set; }

        /// <summary>
        /// The URL for this user's GIPHY profile.
        /// </summary>
        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// The username associated with this user.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// The display name associated with this user (contains formatting the base username might not).
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}
