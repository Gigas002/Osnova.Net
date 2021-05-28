using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Spotify block
    /// </summary>
    public class SpotifyBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public SpotifyBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="SpotifyBlock"/>
        /// </summary>
        public SpotifyBlock() : base(BlockType.Spotify) { }

        /// <summary>
        /// Create <see cref="SpotifyBlock"/> with <see cref="SpotifyBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public SpotifyBlock(SpotifyBlockData data) : this() => Data = data;

        #endregion
    }
}