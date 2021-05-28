using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Image block
    /// </summary>
    public class ImageBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public ImageBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="ImageBlock"/>
        /// </summary>
        public ImageBlock() : base(BlockType.Image) { }

        /// <summary>
        /// Create <see cref="ImageBlock"/> with <see cref="ImageBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public ImageBlock(ImageBlockData data) : this() => Data = data;

        #endregion
    }
}