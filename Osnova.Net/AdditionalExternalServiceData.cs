using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class AdditionalExternalServiceData
    {
        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
        [JsonPropertyName("o_id")]
        public long OId { get; set; }

        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
        [JsonPropertyName("v_id")]
        public long VId { get; set; }
    }
}
