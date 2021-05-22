using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// Doc src: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/entities
    /// </summary>
    public class TwitterHashtag
    {
        /// <summary>
        /// An array of integers indicating the offsets within the Tweet text where the hashtag begins and ends
        /// </summary>
        [JsonPropertyName("indices")]
        public IEnumerable<int> Indices { get; set; }

        /// <summary>
        /// Name of the hashtag, minus the leading ‘#’ character
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
