using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// Doc src: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/entities
    /// </summary>
    public class TwitterUserMentions
    {
        /// <summary>
        /// ID of the mentioned user, as an integer
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// ID of the mentioned user, as a string
        /// </summary>
        [JsonPropertyName("id_str")]
        public string IdString { get; set; }

        /// <summary>
        /// An array of integers representing the offsets within the Tweet text where the user reference begins and ends
        /// </summary>
        [JsonPropertyName("indices")]
        public IEnumerable<int> Indices { get; set; }

        /// <summary>
        /// Display name of the referenced user
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Screen name of the referenced user
        /// </summary>
        [JsonPropertyName("screen_name")]
        public string ScreenName { get; set; }
    }
}
