using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Incut block
    /// </summary>
    public class IncutBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public IncutBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="IncutBlock"/>
        /// </summary>
        public IncutBlock() : base(BlockType.Incut) { }

        /// <summary>
        /// Create <see cref="IncutBlock"/> with <see cref="IncutBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public IncutBlock(IncutBlockData data) : this() => Data = data;

        #endregion
    }
}