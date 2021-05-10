using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Similar
    {
        // TODO: are these all REALLY long? https://cmtt-ru.github.io/osnova-api/redoc.html#operation/getEntryById

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