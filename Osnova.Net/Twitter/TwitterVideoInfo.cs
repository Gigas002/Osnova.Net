using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Twitter video info
    /// </summary>
    public class TwitterVideoInfo
    {
        #region Properties
        
        /// <summary>
        /// Aspect ratio
        /// </summary>
        [JsonPropertyName("aspect_ratio")]
        public IEnumerable<int> AspectRatio { get; set; }

        /// <summary>
        /// Duration in milliseconds
        /// <para/>
        /// <remarks>Refers to "duration_millis" property in json</remarks>
        /// </summary>
        [JsonPropertyName("duration_millis")]
        public int DurationMilliseconds { get; set; }

        /// <summary>
        /// Variants
        /// </summary>
        [JsonPropertyName("variants")]
        public IEnumerable<TwitterVideoInfoVariant> Variants { get; set; }
        
        #endregion
    }
}