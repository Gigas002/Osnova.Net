using System;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Users
{
    public class Subscription
    {
        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }

        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("active_until")]
        public DateTimeOffset ActiveUntil { get; set; }
    }
}