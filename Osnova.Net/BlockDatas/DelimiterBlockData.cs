using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class DelimiterBlockData : BlockData
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
