using System;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Users
{
    public class BanInfo
    {
        [JsonPropertyName("who")]
        public User WhoBanned { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("until")]
        public DateTimeOffset Until { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}