using System;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class TwitterUser
    {
        [JsonPropertyName("created_at")]
        public long CreatedAt { get; set; }

        [JsonPropertyName("followers_count")]
        public int FollowersCount { get; set; }

        [JsonPropertyName("friends_count")]
        public int FriendsCount { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("profile_image_url")]
        public Uri ProfileImageUrl { get; set; }

        [JsonPropertyName("profile_image_url_bigger")]
        public Uri ProfileImageUrlBigger { get; set; }

        [JsonPropertyName("screen_name")]
        public string ScreenName { get; set; }

        [JsonPropertyName("statuses_count")]
        public int StatusesCount { get; set; }
    }
}
