using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Twitter expanded URL
    /// <para/>
    /// <remarks>API version: 1.1;
    /// <para/>
    /// Doc src: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/entities
    /// </remarks>
    /// </summary>
    public class TwitterEntityExpandedUrl
    {
        #region Properties
        
        /// <summary>
        /// The fully unwound version of the link included in the Tweet
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        /// <summary>
        /// Final HTTP status of the unwinding process, a '200' indicating success
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// HTML title for the link
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// HTML description for the link
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        
        #endregion
    }
}
