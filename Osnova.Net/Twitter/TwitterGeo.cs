using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Twitter geo info
    /// <para/>
    /// <remarks>API version: 2.0</remarks>
    /// </summary>
    public class TwitterGeo
    {
        #region Properties
        
        /// <summary>
        /// Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Coordinate borders
        /// <para/>
        /// <remarks>Refers to "id_str" property in json</remarks>
        /// </summary>
        [JsonPropertyName("bbox")]
        public IEnumerable<double> BoundingBox { get; set; }

        /// <summary>
        /// Properties
        /// </summary>
        [JsonPropertyName("properties")]
        public object Properties { get; set; }
        
        #endregion
    }
}
