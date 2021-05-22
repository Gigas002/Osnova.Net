using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// </summary>
    public class TwitterCoordinates
    {
        [JsonPropertyName("coordinates")]
        public IEnumerable<float> Coordinates { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
