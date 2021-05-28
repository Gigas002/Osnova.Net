using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Universal block for external services
    /// <para/>
    /// <remarks>Used in: <see cref="InstagramBlockData"/>, <see cref="SpotifyBlockData"/>,
    /// <see cref="TikTokBlockData"/>, <see cref="YandexMusicBlockData"/></remarks>
    /// </summary>
    public class UniversalBoxBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public UniversalBoxBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="UniversalBoxBlock"/>
        /// </summary>
        public UniversalBoxBlock() : base(BlockType.UniversalBox) { }

        /// <summary>
        /// Create <see cref="UniversalBoxBlock"/> with <see cref="UniversalBoxBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public UniversalBoxBlock(UniversalBoxBlockData data) : this() => Data = data;

        #endregion
    }
}