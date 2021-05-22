using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class DelimiterBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public DelimiterBlockData Data { get; set; }

        #endregion

        #region Constructors

        public DelimiterBlock() : base(BlockType.Delimiter) { }

        public DelimiterBlock(DelimiterBlockData data) : this() => Data = data;

        #endregion
    }
}