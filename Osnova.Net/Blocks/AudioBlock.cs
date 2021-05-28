using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Block with audio data
    /// </summary>
    public class AudioBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public AudioBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="AudioBlock"/>
        /// </summary>
        public AudioBlock() : base(BlockType.Audio) { }

        /// <summary>
        /// Create <see cref="AudioBlock"/> with <see cref="AudioBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public AudioBlock(AudioBlockData data) : this() => Data = data;

        #endregion
    }
}
