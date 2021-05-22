using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class RawHtmlBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public RawHtmlBlockData Data { get; set; }

        #endregion

        #region Constructors

        public RawHtmlBlock() : base(BlockType.RawHtml) { }

        public RawHtmlBlock(RawHtmlBlockData data) : this() => Data = data;

        #endregion
    }
}