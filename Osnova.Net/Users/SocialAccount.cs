using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Users
{
    /// <summary>
    /// User's social account
    /// </summary>
    public class SocialAccount
    {
        #region Properties
        
        /// <summary>
        /// ID
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Account type
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; } // TODO: enum

        /// <summary>
        /// User's username
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }
        
        #endregion
    }
}
