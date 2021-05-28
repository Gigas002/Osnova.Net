using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Person in the block
    /// </summary>
    public class PersonBlockData
    {
        #region Properties

        /// <summary>
        /// Person's image, if any
        /// </summary>
        [JsonPropertyName("image")]
        public ImageBlock Image { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Text value of the block
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        #endregion
    }
}
