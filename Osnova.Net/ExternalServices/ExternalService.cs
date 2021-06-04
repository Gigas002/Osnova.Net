using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.ExternalServices
{
    /// <summary>
    /// External service with some media data
    /// </summary>
    public class ExternalService
    {
        /// <summary>
        /// Name of service
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// URL of mp5 video, if any
        /// </summary>
        [JsonPropertyName("mp4_url")]
        public Uri Mp4Url { get; set; }

        /// <summary>
        /// Some additional data
        /// </summary>
        [JsonPropertyName("additional_data")]
        public AdditionalExternalServiceData AdditionalData { get; set; }
    }
}
