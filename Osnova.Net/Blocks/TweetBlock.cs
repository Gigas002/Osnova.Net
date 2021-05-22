using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class TweetBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public TweetBlockData Data { get; set; }

        #endregion

        #region Constructors

        public TweetBlock() : base(BlockType.Tweet) { }

        public TweetBlock(TweetBlockData data) : this() => Data = data;

        #endregion
    }
}