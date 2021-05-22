using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Twitter.Enterprise;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// </summary>
    public class TwitterEntities
    {
        [JsonPropertyName("hashtags")]
        public IEnumerable<TwitterHashtag> Hashtags { get; set; }

        [JsonPropertyName("media")]
        public IEnumerable<TweetMedia> Media { get; set; }

        [JsonPropertyName("urls")]
        public IEnumerable<TwitterEntityUrl> Urls { get; set; }

        [JsonPropertyName("user_mentions")]
        public IEnumerable<TwitterUserMentions> UserMentions { get; set; }

        [JsonPropertyName("symbols")]
        public IEnumerable<TwitterHashtag> Symbols { get; set; }

        [JsonPropertyName("polls")]
        public IEnumerable<TwitterPoll> Polls { get; set; }
    }
}
