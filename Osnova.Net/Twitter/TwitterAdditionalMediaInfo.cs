using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Additional tweet media info
    /// </summary>
    public class TwitterAdditionalMediaInfo
    {
        #region Properties

        /// <summary>
        /// Title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Is embeddable?
        /// <para/>
        /// <remarks>Refers to "embeddable" property in json</remarks>
        /// </summary>
        [JsonPropertyName("embeddable")]
        public bool IsEmbeddable { get; set; }

        /// <summary>
        /// Is monetizable?
        /// <para/>
        /// <remarks>Refers to "monetizable" property in json</remarks>
        /// </summary>
        [JsonPropertyName("monetizable")]
        public bool IsMonetizable { get; set; }
        
        #endregion
    }
}