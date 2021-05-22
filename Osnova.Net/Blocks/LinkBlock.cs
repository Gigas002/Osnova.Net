using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class LinkBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public LinkBlockData Data { get; set; }

        #endregion

        #region Constructors

        public LinkBlock() : base(BlockType.Link) { }

        public LinkBlock(LinkBlockData data) : this() => Data = data;

        #endregion
    }
}