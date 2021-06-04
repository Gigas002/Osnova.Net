using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Telegram
{
    /// <summary>
    /// Telegram image
    /// </summary>
    public class TelegramPhoto
    {
        #region Properties
        
        /// <summary>
        /// Width of the image
        /// </summary>
        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// Height of the image
        /// </summary>
        [JsonPropertyName("height")]
        public int Height { get; set; }

        /// <summary>
        /// URL of the image on leonardo
        /// </summary>
        [JsonPropertyName("leonardo_url")]
        public Uri LeonardoUrl { get; set; }
        
        #endregion
    }
}
