using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class DelimiterBlockData
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
