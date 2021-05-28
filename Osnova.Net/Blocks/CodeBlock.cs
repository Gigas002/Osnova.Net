using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Block with code-text
    /// </summary>
    public class CodeBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public CodeBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="CodeBlock"/>
        /// </summary>
        public CodeBlock() : base(BlockType.Code) { }

        /// <summary>
        /// Create <see cref="CodeBlock"/> with <see cref="CodeBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public CodeBlock(CodeBlockData data) : this() => Data = data;

        #endregion
    }
}