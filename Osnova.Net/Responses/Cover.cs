using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class Cover
    {
        #region From getUser docs

        [JsonPropertyName("cover_url")]
        public Uri CoverUrl { get; set; }

        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; } // TODO: sometimes string?

        [JsonPropertyName("y")]
        public string Y { get; set; }

        #endregion

        #region From getEntryById docs

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

        #endregion
    }
}
