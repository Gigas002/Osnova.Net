using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Represents a block, called "number" in osnova editor
    /// </summary>
    public class NumberBlockData
    {
        #region Properties

        /// <summary>
        /// Text value of the block
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        #endregion
    }
}
