using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class CodeBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public CodeBlockData Data { get; set; }

        #endregion

        #region Constructors

        public CodeBlock() : base(BlockType.Code) { }

        public CodeBlock(CodeBlockData data) : this() => Data = data;

        #endregion
    }
}