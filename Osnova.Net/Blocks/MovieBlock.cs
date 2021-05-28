using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Video with sound block
    /// </summary>
    public class MovieBlock : Block // TODO: rename?
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public MovieBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="MovieBlock"/>
        /// </summary>
        public MovieBlock() : base(BlockType.Movie) { }

        /// <summary>
        /// Create <see cref="MovieBlock"/> with <see cref="MovieBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public MovieBlock(MovieBlockData data) : this() => Data = data;

        #endregion
    }
}
