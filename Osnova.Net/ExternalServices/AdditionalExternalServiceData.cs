using System.Text.Json.Serialization;

namespace Osnova.Net.ExternalServices
{
    /// <summary>
    /// Additional data for external service's media
    /// </summary>
    public class AdditionalExternalServiceData
    {
        /// <summary>
        /// Hash
        /// </summary>
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
