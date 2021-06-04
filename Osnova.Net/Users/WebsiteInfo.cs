using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Users
{
    /// <summary>
    /// External website's info
    /// </summary>
    public class WebsiteInfo
    {
        #region Properties

        /// <summary>
        /// Title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }
        
        #endregion
    }
}