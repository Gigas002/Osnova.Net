using System;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.Comments
{
    public class CommentMedia
    {
        /// <summary>
        /// Тип медиафайла:
        /// Image = 1
        /// Video = 2
        /// </summary>
        [JsonPropertyName("type")]
        public MediaType Type { get; set; }

        [JsonPropertyName("imageUrl")]
        public Uri ImageUrl { get; set; }

        [JsonPropertyName("iframeUrl")]
        public Uri IframeUrl { get; set; }

        [JsonPropertyName("service")]
        public string Service { get; set; }

        [JsonPropertyName("additionalData")]
        public AdditionalData AdditionalData { get; set; }

        [JsonPropertyName("size")]
        public Size Size { get; set; }
    }
}