using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Text block
    /// </summary>
    public class TextBlockData
    {
        #region Properties

        /// <summary>
        /// Text value
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Text value truncated
        /// </summary>
        [JsonPropertyName("text_truncated")]
        public string TextTruncated { get; set; }

        #endregion
    }
}
