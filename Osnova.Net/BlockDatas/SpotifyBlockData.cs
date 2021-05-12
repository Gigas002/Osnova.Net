using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class SpotifyBlockData
    {
        [JsonPropertyName("spotify")]
        public Block Spotify { get; set; }
    }
}
