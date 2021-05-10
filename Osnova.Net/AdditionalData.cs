using System;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class AdditionalData
    {
        #region From getEntryById docs

        /// <summary>
        ///  "gif" "jpg" "png" "webp"
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        [JsonPropertyName("duration")]
        public long Duration { get; set; }

        [JsonPropertyName("hasAudio")]
        public bool HasAudio { get; set; }

        #endregion
    }
}
