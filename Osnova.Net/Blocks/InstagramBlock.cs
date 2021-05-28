using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Instagram block
    /// </summary>
    public class InstagramBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public InstagramBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="InstagramBlock"/>
        /// </summary>
        public InstagramBlock() : base(BlockType.Instagram) { }

        /// <summary>
        /// Create <see cref="InstagramBlock"/> with <see cref="InstagramBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public InstagramBlock(InstagramBlockData data) : this() => Data = data;

        #endregion
    }
}