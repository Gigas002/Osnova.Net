using System.Text.Json.Serialization;

namespace Osnova.Net.Responses.BlockDatas
{
    public class IncutBlockData : BlockData
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("text_size")]
        public string TextSize { get; set; }
    }
}
