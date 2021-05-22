using System;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class ExternalService
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("mp4_url")]
        public Uri Mp4Url { get; set; }

        [JsonPropertyName("additional_data")]
        public AdditionalExternalServiceData AdditionalData { get; set; }
    }
}
