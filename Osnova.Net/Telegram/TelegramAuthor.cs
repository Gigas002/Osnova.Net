using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Telegram
{
    /// <summary>
    /// Author of telegram post
    /// </summary>
    public class TelegramAuthor
    {
        #region Properties

        /// <summary>
        /// Author's name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Author's avatar's URL
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public Uri AvatarUrl { get; set; }

        /// <summary>
        /// Author's URL
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }
        
        #endregion
    }
}
