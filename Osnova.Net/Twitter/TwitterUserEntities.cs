using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Twitter user entities
    /// <para/>
    /// <remarks>API version: 1.1</remarks>
    /// </summary>
    public class TwitterUserEntities
    {
        #region Properties

        /// <summary>
        /// URL
        /// </summary>
        [JsonPropertyName("url")]
        public TwitterEntities Url { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonPropertyName("description")]
        public TwitterEntities Description { get; set; }
        
        #endregion
    }
}
