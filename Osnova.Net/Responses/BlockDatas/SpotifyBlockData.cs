using System.Text.Json.Serialization;
using Osnova.Net.Responses.Blocks;

namespace Osnova.Net.Responses.BlockDatas
{
    public class SpotifyBlockData : BlockData
    {
        [JsonPropertyName("spotify")]
        public Block Spotify { get; set; }
    }
}
