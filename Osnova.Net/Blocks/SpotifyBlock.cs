using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class SpotifyBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public SpotifyBlockData Data { get; set; }

        #endregion

        #region Constructors

        public SpotifyBlock() : base(BlockType.Spotify) { }

        public SpotifyBlock(SpotifyBlockData data) : this() => Data = data;

        #endregion
    }
}