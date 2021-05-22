using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class QuizBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public QuizBlockData Data { get; set; }

        #endregion

        #region Constructors

        public QuizBlock() : base(BlockType.Quiz) { }

        public QuizBlock(QuizBlockData data) : this() => Data = data;

        #endregion
    }
}