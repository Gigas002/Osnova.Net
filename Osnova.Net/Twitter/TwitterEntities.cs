using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Twitter.Enterprise;

namespace Osnova.Net.Twitter
{
    /// <summary>
    ///Twitter entities
    /// <para/>
    /// <remarks>API version: 1.1;
    /// <para/>
    /// Doc src: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/entities
    /// </remarks>
    /// </summary>
    public class TwitterEntities
    {
        #region Properties

        /// <summary>
        /// Represents hashtags which have been parsed out of the Tweet text
        /// </summary>
        [JsonPropertyName("hashtags")]
        public IEnumerable<TwitterHashtag> Hashtags { get; set; }

        /// <summary>
        /// Represents media elements uploaded with the Tweet
        /// </summary>
        [JsonPropertyName("media")]
        public IEnumerable<TweetMedia> Media { get; set; }

        /// <summary>
        /// Represents URLs included in the text of a Tweet
        /// </summary>
        [JsonPropertyName("urls")]
        public IEnumerable<TwitterEntityUrl> Urls { get; set; }

        /// <summary>
        /// Represents other Twitter users mentioned in the text of the Tweet
        /// </summary>
        [JsonPropertyName("user_mentions")]
        public IEnumerable<TwitterUserMentions> UserMentions { get; set; }

        /// <summary>
        /// Represents symbols, i.e. $cashtags, included in the text of the Tweet
        /// </summary>
        [JsonPropertyName("symbols")]
        public IEnumerable<TwitterHashtag> Symbols { get; set; }

        /// <summary>
        /// Represents Twitter Polls included in the Tweet
        /// </summary>
        [JsonPropertyName("polls")]
        public IEnumerable<TwitterPoll> Polls { get; set; }
        
        #endregion
    }
}
