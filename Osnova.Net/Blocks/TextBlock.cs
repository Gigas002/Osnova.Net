using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Text block
    /// </summary>
    public class TextBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public TextBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="TextBlock"/>
        /// </summary>
        public TextBlock() : base(BlockType.Text) { }

        /// <summary>
        /// Create <see cref="TextBlock"/> with <see cref="TextBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public TextBlock(TextBlockData data) : this() => Data = data;

        #endregion
    }
}