using System.Text.Json.Serialization;
using Osnova.Net.Responses.Blocks;

namespace Osnova.Net.Responses.BlockDatas
{
    public class PersonBlockData : BlockData
    {
        [JsonPropertyName("image")]
        public Block Image { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
