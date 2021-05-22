using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class YaMusicBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public YaMusicBlockData Data { get; set; }

        #endregion

        #region Constructors

        public YaMusicBlock() : base(BlockType.YaMusic) { }

        public YaMusicBlock(YaMusicBlockData data) : this() => Data = data;

        #endregion
    }
}