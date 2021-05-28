using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Raw HTML block
    /// <para/>
    /// <remarks>Editoral block</remarks>
    /// </summary>
    public class RawHtmlBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public RawHtmlBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="RawHtmlBlock"/>
        /// </summary>
        public RawHtmlBlock() : base(BlockType.RawHtml) { }

        /// <summary>
        /// Create <see cref="RawHtmlBlock"/> with <see cref="RawHtmlBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public RawHtmlBlock(RawHtmlBlockData data) : this() => Data = data;

        #endregion
    }
}