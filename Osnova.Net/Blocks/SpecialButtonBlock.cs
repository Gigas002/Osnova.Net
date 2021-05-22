using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class SpecialButtonBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public SpecialButtonBlockData Data { get; set; }

        #endregion

        #region Constructors

        public SpecialButtonBlock() : base(BlockType.SpecialButton) { }

        public SpecialButtonBlock(SpecialButtonBlockData data) : this() => Data = data;

        #endregion
    }
}