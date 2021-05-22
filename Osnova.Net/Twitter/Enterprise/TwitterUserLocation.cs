using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter.Enterprise
{
    /// <summary>
    /// 1.1/2.0
    /// </summary>
    public class TwitterUserLocation
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("country_code")]
        public string ConutryCode { get; set; }

        [JsonPropertyName("locality")]
        public string Locality { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("sub_region")]
        public string SubRegion { get; set; }

        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        [JsonPropertyName("geo")]
        public TwitterCoordinates<IEnumerable<float>> Geo { get; set; }
    }
}
