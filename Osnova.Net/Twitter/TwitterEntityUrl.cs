using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// </summary>
    public class TwitterEntityUrl
    {
        [JsonPropertyName("display_url")]
        public Uri DisplayUrl { get; set; }

        [JsonPropertyName("expanded_url")]
        public Uri ExpandedUrl { get; set; }

        [JsonPropertyName("indices")]
        public IEnumerable<int> Indices { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("unwound")]
        public TwitterEntityExpandedUrl Unwound { get; set; }
    }
}
