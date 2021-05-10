using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class YaMusicBlockData : BlockData
    {
        [JsonPropertyName("yamusic")]
        public Block YaMusic { get; set; }
    }
}
