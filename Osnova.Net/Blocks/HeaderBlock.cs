using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class HeaderBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public HeaderBlockData Data { get; set; }

        #endregion

        #region Constructors

        public HeaderBlock() : base(BlockType.Header) { }

        public HeaderBlock(HeaderBlockData data) : this() => Data = data;

        #endregion
    }
}