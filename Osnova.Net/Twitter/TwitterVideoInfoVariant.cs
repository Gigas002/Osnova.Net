using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Twitter video info variant
    /// </summary>
    public class TwitterVideoInfoVariant
    {
        #region Properties

        /// <summary>
        /// Bitrate
        /// </summary>
        [JsonPropertyName("bitrate")]
        public int Bitrate { get; set; }

        /// <summary>
        /// Content type
        /// </summary>
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }
        
        #endregion
    }
}