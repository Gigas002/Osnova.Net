using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Link block
    /// </summary>
    public class LinkBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public LinkBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="LinkBlock"/>
        /// </summary>
        public LinkBlock() : base(BlockType.Link) { }

        /// <summary>
        /// Create <see cref="LinkBlock"/> with <see cref="LinkBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public LinkBlock(LinkBlockData data) : this() => Data = data;

        #endregion
    }
}