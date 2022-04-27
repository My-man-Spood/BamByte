using Bambyte.GiphyWrapper.Models;
using Bambyte.GiphyWrapper.Models.Renditions;
using Discord;

namespace Bambyte.GiphyWrapper
{
    public static class EmbedBuilderGiphyExtension
    {
        private const string DefaultGiphyAvatarUrl = "https://cdn.iconscout.com/icon/free/png-256/giphy-461796.png";
        private const string LostJohnTravolta = "https://media.giphy.com/media/2vlC9FMLSmqGs/giphy.gif";

        public static Embed BuildFromGifData(this EmbedBuilder builder, GifData data, string gifName)
        {
            return builder
                .WithAuthor(new EmbedAuthorBuilder().FromGiphyUser(data.User))
                .WithImageUrl(GetLargestDownsizedUrl(data?.Images) ?? LostJohnTravolta)
                .WithTitle(data?.Title ?? gifName)
                .WithDescription($"\"{gifName}\" via Giphy")
                .Build();
        }

        public static EmbedAuthorBuilder FromGiphyUser(this EmbedAuthorBuilder builder, User user)
        {
            return builder
                .WithName(user?.DisplayName ?? user?.Username ?? "Unknown giphy user")
                .WithUrl(user?.ProfileUrl ?? string.Empty)
                .WithIconUrl(user?.AvatarUrl ?? DefaultGiphyAvatarUrl);
        }

        private static string GetLargestDownsizedUrl(Renditions renditions)
        {
            return renditions.DownSizedLarge?.Url ??
                renditions.DownSizedMedium?.Url ??
                renditions.DownSized?.Url;
        }
    }
}
