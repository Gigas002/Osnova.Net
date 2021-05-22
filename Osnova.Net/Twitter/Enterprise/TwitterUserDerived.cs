using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter.Enterprise
{
    /// <summary>
    /// 1.1/2.0
    /// </summary>
    public class TwitterUserDerived
    {
        [JsonPropertyName("locations")]
        public IEnumerable<TwitterUserLocation> Locations { get; set; }
    }
}
