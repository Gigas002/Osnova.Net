using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class QuoteBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public QuoteBlockData Data { get; set; }

        #endregion

        #region Constructors

        public QuoteBlock() : base(BlockType.Quote) { }

        public QuoteBlock(QuoteBlockData data) : this() => Data = data;

        #endregion
    }
}