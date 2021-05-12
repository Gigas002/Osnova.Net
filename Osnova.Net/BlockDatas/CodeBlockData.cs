using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class CodeBlockData
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("lang")]
        public string Lang { get; set; }
    }
}
