using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class Media
    {
        /// <summary>
        /// Enum: 1 2
        /// Тип медиафайла:
        /// 1 - TYPE_IMAGE
        /// 2 - TYPE_VIDEO
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; }

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