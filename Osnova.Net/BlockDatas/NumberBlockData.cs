using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class NumberBlockData : BlockData
    {
        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
