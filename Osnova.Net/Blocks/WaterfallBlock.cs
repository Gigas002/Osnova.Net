using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class WaterfallBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public WaterfallBlockData Data { get; set; }

        #endregion

        #region Constructors

        public WaterfallBlock() : base(BlockType.Waterfall) { }

        public WaterfallBlock(WaterfallBlockData data) : this() => Data = data;

        #endregion
    }
}