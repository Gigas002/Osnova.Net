using System;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Watcher // TODO: rename? See getApiWebhooksGet
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("event")]
        public string EventName { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}
