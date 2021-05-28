using System;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Cover
    {
        [JsonPropertyName("type")]
        public int Type { get; set; } // TODO: enum

        [JsonPropertyName("additionalData")]
        public AdditionalData AdditionalData { get; set; }

        /// <summary>
        /// Cover's thumbnail URL
        /// </summary>
        [JsonPropertyName("thumbnailUrl")]
        public Uri ThumbnailUrl { get; set; }

        /// <summary>
        /// Cover URL
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        /// <summary>
        /// Cover's size
        /// </summary>
        [JsonPropertyName("size")]
        public Size Size { get; set; }

        /// <summary>
        /// Simplified cover size
        /// </summary>
        [JsonPropertyName("size_simple")]
        public string SizeSimple { get; set; }
    }
}
