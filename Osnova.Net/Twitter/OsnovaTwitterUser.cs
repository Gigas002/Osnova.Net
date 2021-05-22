using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// OsnovaShit
    /// </summary>
    public class OsnovaTwitterUser
    {
        #region Same as 1.1 spec's TweetUser

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("followers_count")]
        public int FollowersCount { get; set; }

        [JsonPropertyName("friends_count")]
        public int FriendsCount { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("profile_image_url")]
        public Uri ProfileImageUrl { get; set; }

        [JsonPropertyName("screen_name")]
        public string ScreenName { get; set; }

        [JsonPropertyName("statuses_count")]
        public int StatusesCount { get; set; }

        #endregion

        #region Wrong data type

        // string != long
        [JsonPropertyName("created_at")]
        public long CreatedAt { get; set; }

        #endregion

        #region OsnovaShit

        [JsonPropertyName("profile_image_url_bigger")]
        public Uri ProfileImageUrlBigger { get; set; }

        #endregion
    }
}
