using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class MediaBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public MediaBlockData Data { get; set; }

        #endregion

        #region Constructors

        public MediaBlock() : base(BlockType.Media) { }

        public MediaBlock(MediaBlockData data) : this() => Data = data;

        #endregion
    }
}