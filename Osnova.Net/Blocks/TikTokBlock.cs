using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class TikTokBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public TikTokBlockData Data { get; set; }

        #endregion

        #region Constructors

        public TikTokBlock() : base(BlockType.TikTok) { }

        public TikTokBlock(TikTokBlockData data) : this() => Data = data;

        #endregion
    }
}