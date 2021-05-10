using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class AdvancedAccess
    {
        [JsonPropertyName("is_needs_advanced_access")]
        public bool IsNeedsAdvancedAccess { get; set; }

        [JsonPropertyName("actions")]
        public AdvancedAccessActions Actions { get; set; }

        [JsonPropertyName("dtf_subscription")]
        public Subscription DtfSubscription { get; set; }

        [JsonPropertyName("tv_subscription")]
        public Subscription TvSubscription { get; set; }

        [JsonPropertyName("vc_subscription")]
        public Subscription VcSubscription { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }
    }
}