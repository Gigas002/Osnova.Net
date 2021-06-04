using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter.Enterprise
{
    /// <summary>
    /// API version: 1.1/2.0
    /// </summary>
    public class TwitterUserLocation
    {
        #region Properties
        
        /// <summary>
        /// Country
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        [JsonPropertyName("country_code")]
        public string ConutryCode { get; set; }

        /// <summary>
        /// Locality
        /// </summary>
        [JsonPropertyName("locality")]
        public string Locality { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// Subregion
        /// </summary>
        [JsonPropertyName("sub_region")]
        public string SubRegion { get; set; }

        /// <summary>
        /// Full name
        /// </summary>
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// Geo coordinates
        /// </summary>
        [JsonPropertyName("geo")]
        public TwitterCoordinates<IEnumerable<float>> Geo { get; set; }
        
        #endregion
    }
}
