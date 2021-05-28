using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Tweet block
    /// </summary>
    public class TweetBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public TweetBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="TweetBlock"/>
        /// </summary>
        public TweetBlock() : base(BlockType.Tweet) { }

        /// <summary>
        /// Create <see cref="TweetBlock"/> with <see cref="TweetBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public TweetBlock(TweetBlockData data) : this() => Data = data;

        #endregion
    }
}