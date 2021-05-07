using System.Text.Json.Serialization;

namespace Osnova.Net.Responses.BlockDatas
{
    public class TextBlockData : BlockData
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("text_truncated")]
        public string TextTruncated { get; set; }
    }
}
