using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Twtitter hashtag
    /// <para/>
    /// <remarks>API version: 1.1;
    /// <para/>
    /// Doc src: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/entities
    /// </remarks>
    /// </summary>
    public class TwitterHashtag
    {
        #region Properties

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
        
        #endregion
    }
}
