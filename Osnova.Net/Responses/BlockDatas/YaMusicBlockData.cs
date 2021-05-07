using System.Text.Json.Serialization;
using Osnova.Net.Responses.Blocks;

namespace Osnova.Net.Responses.BlockDatas
{
    public class YaMusicBlockData : BlockData
    {
        [JsonPropertyName("yamusic")]
        public Block YaMusic { get; set; }
    }
}
