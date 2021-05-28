using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Waterfall block for continious data
    /// <para/>
    /// <remarks>Editoral block</remarks>
    /// </summary>
    public class WaterfallBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public WaterfallBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="WaterfallBlock"/>
        /// </summary>
        public WaterfallBlock() : base(BlockType.Waterfall) { }

        /// <summary>
        /// Create <see cref="WaterfallBlock"/> with <see cref="WaterfallBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public WaterfallBlock(WaterfallBlockData data) : this() => Data = data;

        #endregion
    }
}