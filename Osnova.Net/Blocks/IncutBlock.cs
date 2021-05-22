using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class IncutBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public IncutBlockData Data { get; set; }

        #endregion

        #region Constructors

        public IncutBlock() : base(BlockType.Incut) { }

        public IncutBlock(IncutBlockData data) : this() => Data = data;

        #endregion
    }
}