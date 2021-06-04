using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Twitter coordinates
    /// <para/>
    /// <remarks>API version: 1.1;
    /// <para/>
    /// Doc source: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/geo
    /// </remarks>
    /// </summary>
    public class TwitterCoordinates<T>
    {
        #region Properties

        /// <summary>
        /// Collection of coordinates
        /// </summary>
        [JsonPropertyName("coordinates")]
        public T Coordinates { get; set; }

        /// <summary>
        /// The type of data encoded in the coordinates property
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
        
        #endregion
    }
}
