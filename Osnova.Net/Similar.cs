using System;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    [Obsolete("Use Entry instead")]
    public class Similar
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public long Title { get; set; }

        [JsonPropertyName("url")]
        public long Url { get; set; }

        [JsonPropertyName("date")]
        public long Date { get; set; }

        [JsonPropertyName("dateRFC")]
        public long DateRFC { get; set; }
    }
}