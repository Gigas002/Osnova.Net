using System.Text.Json.Serialization;

namespace Osnova.Net.Users
{
    /// <summary>
    /// User's advanced access properties
    /// </summary>
    public class AdvancedAccess
    {
        #region Properties
        
        /// <summary>
        /// Is this user needs advanced acceess?
        /// </summary>
        [JsonPropertyName("is_needs_advanced_access")]
        public bool IsNeedsAdvancedAccess { get; set; }

        /// <summary>
        /// Additional actions
        /// </summary>
        [JsonPropertyName("actions")]
        public AdvancedAccessActions Actions { get; set; }

        /// <summary>
        /// DTF subscription
        /// </summary>
        [JsonPropertyName("dtf_subscription")]
        public Subscription DtfSubscription { get; set; }

        /// <summary>
        /// Tjournal subscription
        /// <para/>
        /// <remarks>Refers to "tv_subscription" property in json</remarks>
        /// </summary>
        [JsonPropertyName("tv_subscription")]
        public Subscription TjournalSubscription { get; set; }

        /// <summary>
        /// VC subscription
        /// </summary>
        [JsonPropertyName("vc_subscription")]
        public Subscription VcSubscription { get; set; }

        /// <summary>
        /// Hash
        /// </summary>
        [JsonPropertyName("hash")]
        public string Hash { get; set; }
        
        #endregion
    }
}