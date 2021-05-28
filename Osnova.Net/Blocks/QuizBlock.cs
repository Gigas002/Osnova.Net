using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Quiz block
    /// </summary>
    public class QuizBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public QuizBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="QuizBlock"/>
        /// </summary>
        public QuizBlock() : base(BlockType.Quiz) { }

        /// <summary>
        /// Create <see cref="QuizBlock"/> with <see cref="QuizBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public QuizBlock(QuizBlockData data) : this() => Data = data;

        #endregion
    }
}