using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// List block
    /// </summary>
    public class ListBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public ListBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="ListBlock"/>
        /// </summary>
        public ListBlock() : base(BlockType.List) { }

        /// <summary>
        /// Create <see cref="ListBlock"/> with <see cref="ListBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public ListBlock(ListBlockData data) : this() => Data = data;

        #endregion
    }
}