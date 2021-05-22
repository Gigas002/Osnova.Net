using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class WarningBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public WarningBlockData Data { get; set; }

        #endregion

        #region Constructors

        public WarningBlock() : base(BlockType.Warning) { }

        public WarningBlock(WarningBlockData data) : this() => Data = data;

        #endregion
    }
}