using System;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.Comments
{
    /// <summary>
    /// Comment's media
    /// <para/>
    /// <remarks>Refers to "Medium" specification</remarks>
    /// </summary>
    public class CommentMedia
    {
        /// <summary>
        /// Media type
        /// </summary>
        [JsonPropertyName("type")]
        public MediaType Type { get; set; }

        /// <summary>
        /// Image URL, if type is image
        /// </summary>
        [JsonPropertyName("imageUrl")]
        public Uri ImageUrl { get; set; }

        /// <summary>
        /// Iframe URL, if type is video
        /// </summary>
        [JsonPropertyName("iframeUrl")]
        public Uri IframeUrl { get; set; }

        /// <summary>
        /// External service name
        /// </summary>
        [JsonPropertyName("service")]
        public string Service { get; set; }

        /// <summary>
        /// Additional info
        /// </summary>
        [JsonPropertyName("additionalData")]
        public AdditionalData AdditionalData { get; set; }

        /// <summary>
        /// Media sizes
        /// </summary>
        [JsonPropertyName("size")]
        public Size Size { get; set; }
    }
}