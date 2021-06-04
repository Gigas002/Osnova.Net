using System;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Users
{
    /// <summary>
    /// User's ban info
    /// </summary>
    public class BanInfo
    {
        #region Properties
        
        /// <summary>
        /// User, who banned current user
        /// <para/>
        /// <remarks>Refers to "who" property in json</remarks>
        /// </summary>
        [JsonPropertyName("who")]
        public User WhoBanned { get; set; }

        /// <summary>
        /// Ban text
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Date, until ban is valid
        /// </summary>
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("until")]
        public DateTimeOffset Until { get; set; }

        /// <summary>
        /// Why is this user banned?
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
        
        #endregion
    }
}