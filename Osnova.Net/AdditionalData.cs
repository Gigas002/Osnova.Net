using System;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class AdditionalData
    {
        #region Properties

        /// <summary>
        /// Extension of underlying images
        /// </summary>
        [JsonPropertyName("type")]
        public MediaExtension Extension { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        [JsonPropertyName("hasAudio")]
        public bool HasAudio { get; set; }

        #endregion
    }
}
