using System.Text.Json.Serialization;
using Osnova.Net.Blocks;
using Osnova.Net.Enums;

namespace Osnova.Net.BlockDatas
{
    public class QuoteBlockData
    {
        #region Properties

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("subline1")]
        public string Subline1 { get; set; }

        [JsonPropertyName("subline2")]
        public string Subline2 { get; set; }

        [JsonPropertyName("type")]
        public QuoteType Type { get; set; }

        [JsonPropertyName("text_size")]
        public TextSize TextSize { get; set; }

        [JsonPropertyName("image")]
        public ImageBlock Image { get; set; }

        #endregion
    }
}
