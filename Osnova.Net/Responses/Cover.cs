using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class Cover
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("additionalData")]
        public AdditionalData AdditionalData { get; set; }

        [JsonPropertyName("thumbnailUrl")]
        public Uri ThumbnailUrl { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("size")]
        public Size Size { get; set; }

        [JsonPropertyName("size_simple")]
        public string SizeSimple { get; set; }
    }
}
