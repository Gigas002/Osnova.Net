using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Delimiter block
    /// </summary>
    public class DelimiterBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public DelimiterBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="DelimiterBlock"/>
        /// </summary>
        public DelimiterBlock() : base(BlockType.Delimiter) { }

        /// <summary>
        /// Create <see cref="DelimiterBlock"/> with <see cref="DelimiterBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public DelimiterBlock(DelimiterBlockData data) : this() => Data = data;

        #endregion
    }
}