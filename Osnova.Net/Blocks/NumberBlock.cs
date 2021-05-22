using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class NumberBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public NumberBlockData Data { get; set; }

        #endregion

        #region Constructors

        public NumberBlock() : base(BlockType.Number) { }

        public NumberBlock(NumberBlockData data) : this() => Data = data;

        #endregion
    }
}