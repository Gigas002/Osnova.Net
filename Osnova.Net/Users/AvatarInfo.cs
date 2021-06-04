using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Users
{
    /// <summary>
    /// User's avatar info
    /// </summary>
    public class AvatarInfo
    {
        #region Properties

        /// <summary>
        /// Avatar's URL
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public Uri AvatarUrl { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        #endregion
    }
}