using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Number block
    /// </summary>
    public class NumberBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public NumberBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="NumberBlock"/>
        /// </summary>
        public NumberBlock() : base(BlockType.Number) { }

        /// <summary>
        /// Create <see cref="NumberBlock"/> with <see cref="NumberBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public NumberBlock(NumberBlockData data) : this() => Data = data;

        #endregion
    }
}