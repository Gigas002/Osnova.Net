using System;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// OsnovaShit
    /// Used for GetTweets method only
    /// Refers to TweetUser spec
    /// </summary>
    public class OsnovaTwitterUser : TwitterUser
    {
        #region Properties

        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("created_at")]
        public new DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("profile_image_url_bigger")]
        public Uri ProfileImageUrlBigger { get; set; }

        #endregion
    }
}
