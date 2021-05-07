using System.Text.Json.Serialization;

namespace Osnova.Net.Responses.BlockDatas
{
    public class HeaderBlockData : BlockData
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }
    }
}
