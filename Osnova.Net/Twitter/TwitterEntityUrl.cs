using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Twitter entity URL
    /// <para/>
    /// <remarks>API version: 1.1;
    /// <para/>
    /// Doc src: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/entities
    /// </remarks>
    /// </summary>
    public class TwitterEntityUrl
    {
        #region Properties
        
        /// <summary>
        /// URL pasted/typed into Tweet
        /// </summary>
        [JsonPropertyName("display_url")]
        public Uri DisplayUrl { get; set; }

        /// <summary>
        /// Expanded version of display_url
        /// </summary>
        [JsonPropertyName("expanded_url")]
        public Uri ExpandedUrl { get; set; }

        /// <summary>
        /// An array of integers representing offsets within the Tweet text where the URL begins and ends
        /// </summary>
        [JsonPropertyName("indices")]
        public IEnumerable<int> Indices { get; set; }

        /// <summary>
        /// Wrapped URL, corresponding to the value embedded directly into the raw Tweet text, and the values for the indices parameter
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        /// <summary>
        /// Used with Expanded and/or Enhanced URL enrichments
        /// </summary>
        [JsonPropertyName("unwound")]
        public TwitterEntityExpandedUrl Unwound { get; set; }
        
        #endregion
    }
}
