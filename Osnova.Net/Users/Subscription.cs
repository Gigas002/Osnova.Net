using System;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Users
{
    /// <summary>
    /// User's subscription
    /// </summary>
    public class Subscription
    {
        #region Properties

        /// <summary>
        /// Is subscription active?
        /// </summary>
        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }

        /// <summary>
        /// Date, until which subscription is active
        /// </summary>
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("active_until")]
        public DateTimeOffset ActiveUntil { get; set; }
        
        #endregion
    }
}