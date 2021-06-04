using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter.Enterprise
{
    /// <summary>
    /// API version: 1.1/2.0;
    /// <para/>
    /// Doc src: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/geo
    /// </summary>
    public class TwitterUserDerived
    {
        #region Properties
        
        /// <summary>
        /// Derived location from the profile geo enrichement
        /// </summary>
        [JsonPropertyName("locations")]
        public IEnumerable<TwitterUserLocation> Locations { get; set; }
        
        #endregion
    }
}
