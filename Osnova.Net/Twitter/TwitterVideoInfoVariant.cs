using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    public class TwitterVideoInfoVariant
    {
        [JsonPropertyName("bitrate")]
        public int Bitrate { get; set; }

        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}