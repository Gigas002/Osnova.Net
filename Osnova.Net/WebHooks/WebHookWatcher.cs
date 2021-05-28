using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.WebHooks
{
    /// <summary>
    /// Refers to Watcher spec
    /// </summary>
    public class WebhookWatcher
    {
        /// <summary>
        /// Event ID
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Event name
        /// </summary>
        [JsonPropertyName("event")]
        public string EventName { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }
    }
}
