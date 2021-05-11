using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class WarningBlockData : BlockData
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
