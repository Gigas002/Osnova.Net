using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// Doc source: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/geo
    /// </summary>
    public class TwitterCoordinates<T>
    {
        [JsonPropertyName("coordinates")]
        public T Coordinates { get; set; }

        /// <summary>
        /// The type of data encoded in the coordinates property
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
