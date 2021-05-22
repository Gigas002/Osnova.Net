using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class VideoBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public VideoBlockData Data { get; set; }

        #endregion

        #region Constructors

        public VideoBlock() : base(BlockType.Video) { }

        public VideoBlock(VideoBlockData data) : this() => Data = data;

        #endregion
    }
}