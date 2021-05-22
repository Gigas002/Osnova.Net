using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class TextBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public TextBlockData Data { get; set; }

        #endregion

        #region Constructors

        public TextBlock() : base(BlockType.Text) { }

        public TextBlock(TextBlockData data) : this() => Data = data;

        #endregion
    }
}