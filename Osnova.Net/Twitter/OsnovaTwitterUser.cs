using System;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Osnova implementation of <see cref="TwitterUser"/> v 1.1;
    /// Used for GetTweets method only
    /// <para/>
    /// <remarks>Refers to TweetUser spec</remarks>
    /// </summary>
    public class OsnovaTwitterUser : TwitterUser
    {
        #region Properties
        
        /// <summary>
        /// Date, when this user was created
        /// </summary>
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("created_at")]
        public new DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Profile image's URL
        /// </summary>
        [JsonPropertyName("profile_image_url_bigger")]
        public Uri ProfileImageUrlBigger { get; set; }

        #endregion
    }
}
