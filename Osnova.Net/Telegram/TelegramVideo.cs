using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Telegram
{
    /// <summary>
    /// Telegram video
    /// </summary>
    public class TelegramVideo
    {
        #region Properties

        /// <summary>
        /// URL of the video
        /// <para/>
        /// <remarks>Refers to "src" property in json</remarks>
        /// </summary>
        [JsonPropertyName("src")]
        public Uri Url { get; set; }

        /// <summary>
        /// Thumbnail image's URL
        /// </summary>
        [JsonPropertyName("thumbnail_url")]
        public Uri ThumbnailUrl { get; set; }

        /// <summary>
        /// Ratio
        /// </summary>
        [JsonPropertyName("ratio")]
        public double Ratio { get; set; }

        /// <summary>
        /// Width
        /// </summary>
        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        [JsonPropertyName("height")]
        public int Height { get; set; }
        
        #endregion
    }
}
