using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Users
{
    /// <summary>
    /// User, who was mentioned somewhere on the website
    /// </summary>
    public class MentionedUser : User
    {
        #region Properties

        /// <summary>
        /// User's name
        /// <para/>
        /// <remarks>Refers to "text" property in json</remarks>
        /// </summary>
        [JsonPropertyName("text")]
        public new string Name { get; set; }

        /// <summary>
        /// User's avatar URL
        /// <para/>
        /// <remarks>Refers to "img" property in json</remarks>
        /// </summary>
        [JsonPropertyName("img")]
        public new Uri AvatarUrl { get; set; }

        /// <summary>
        /// Is mentioned user me?
        /// </summary>
        [JsonPropertyName("is_me")]
        public bool IsMe { get; set; }
        
        #endregion
    }
}
