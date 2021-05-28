using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// TikTok block
    /// </summary>
    public class TikTokBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public TikTokBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="TikTokBlock"/>
        /// </summary>
        public TikTokBlock() : base(BlockType.TikTok) { }

        /// <summary>
        /// Create <see cref="TikTokBlock"/> with <see cref="TikTokBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public TikTokBlock(TikTokBlockData data) : this() => Data = data;

        #endregion
    }
}