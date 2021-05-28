using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Incuts in blocks
    /// </summary>
    public class IncutBlockData
    {
        #region Properties

        /// <summary>
        /// Text value
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Alignment of text in incut
        /// <para/>
        /// <remarks>Refers to "type" in json</remarks>
        /// </summary>
        [JsonPropertyName("type")]
        public Alignment TextAlignment { get; set; }

        /// <summary>
        /// Text's size
        /// </summary>
        [JsonPropertyName("text_size")]
        public TextSize TextSize { get; set; }

        #endregion
    }
}
