using System.Text.Json.Serialization;
using Osnova.Net.Blocks;
using Osnova.Net.Enums;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Quote
    /// </summary>
    public class QuoteBlockData
    {
        #region Properties

        /// <summary>
        /// Text value
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Subline 1
        /// </summary>
        [JsonPropertyName("subline1")]
        public string Subline1 { get; set; } // TODO: better naming?

        /// <summary>
        /// Subline 2
        /// </summary>
        [JsonPropertyName("subline2")]
        public string Subline2 { get; set; }

        /// <summary>
        /// Quote type
        /// </summary>
        [JsonPropertyName("type")]
        public QuoteType Type { get; set; }

        /// <summary>
        /// Size of text
        /// </summary>
        [JsonPropertyName("text_size")]
        public TextSize TextSize { get; set; }

        /// <summary>
        /// Quote's image, if any
        /// </summary>
        [JsonPropertyName("image")]
        public ImageBlock Image { get; set; }

        #endregion
    }
}
