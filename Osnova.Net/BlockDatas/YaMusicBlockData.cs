using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class YaMusicBlockData
    {
        [JsonPropertyName("yamusic")]
        public Block YaMusic { get; set; }
    }
}
