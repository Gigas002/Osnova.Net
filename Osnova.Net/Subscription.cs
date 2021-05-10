using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Subscription
    {
        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }

        [JsonPropertyName("active_until")]
        public long ActiveUntil { get; set; }
    }
}