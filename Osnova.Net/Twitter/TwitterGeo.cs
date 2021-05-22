using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 2.0
    /// </summary>
    public class TwitterGeo
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("bbox")]
        public IEnumerable<double> BoundingBox { get; set; }

        [JsonPropertyName("properties")]
        public object Properties { get; set; }
    }
}
