using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Quote block
    /// </summary>
    public class QuoteBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public QuoteBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="QuoteBlock"/>
        /// </summary>
        public QuoteBlock() : base(BlockType.Quote) { }

        /// <summary>
        /// Create <see cref="QuoteBlock"/> with <see cref="QuoteBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public QuoteBlock(QuoteBlockData data) : this() => Data = data;

        #endregion
    }
}