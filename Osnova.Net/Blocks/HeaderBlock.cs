using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Header block
    /// </summary>
    public class HeaderBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public HeaderBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="HeaderBlock"/>
        /// </summary>
        public HeaderBlock() : base(BlockType.Header) { }

        /// <summary>
        /// Create <see cref="HeaderBlock"/> with <see cref="HeaderBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public HeaderBlock(HeaderBlockData data) : this() => Data = data;

        #endregion
    }
}