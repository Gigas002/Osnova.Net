using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class ImageBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public ImageBlockData Data { get; set; }

        #endregion

        #region Constructors

        public ImageBlock() : base(BlockType.Image) { }

        public ImageBlock(ImageBlockData data) : this() => Data = data;

        #endregion
    }
}