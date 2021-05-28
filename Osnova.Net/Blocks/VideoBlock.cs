using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Video without sound or gif block
    /// </summary>
    public class VideoBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public VideoBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="VideoBlock"/>
        /// </summary>
        public VideoBlock() : base(BlockType.Video) { }

        /// <summary>
        /// Create <see cref="VideoBlock"/> with <see cref="VideoBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public VideoBlock(VideoBlockData data) : this() => Data = data;

        #endregion
    }
}