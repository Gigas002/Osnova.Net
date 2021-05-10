using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class QuoteBlockData : BlockData
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("subline1")]
        public string Subline1 { get; set; }

        [JsonPropertyName("subline2")]
        public string Subline2 { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("text_size")]
        public string TextSize { get; set; }

        [JsonPropertyName("image")]
        public Block Image { get; set; }
    }
}
