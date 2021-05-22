using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// </summary>
    public class TweetMedia
    {
        [JsonPropertyName("display_url")]
        public Uri DisplayUrl { get; set; }

        [JsonPropertyName("expanded_url")]
        public Uri ExpandedUrl { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("id_str")]
        public string IdString { get; set; }

        [JsonPropertyName("indices")]
        public IEnumerable<int> Indices { get; set; }

        [JsonPropertyName("media_url")]
        public Uri MediaUrl { get; set; }

        [JsonPropertyName("media_url_https")]
        public Uri MediaUrlHttps { get; set; }

        [JsonPropertyName("sizes")]
        public TweetMediaSizes Sizes { get; set; }

        public long? SourceStatusId { get; set; }

        public string SourceStatusIdString { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; } // TODO: enum

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}
