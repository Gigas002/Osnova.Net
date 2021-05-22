using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class AudioBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public AudioBlockData Data { get; set; }

        #endregion

        #region Constructors

        public AudioBlock() : base(BlockType.Audio) { }

        public AudioBlock(AudioBlockData data) : this() => Data = data;

        #endregion
    }
}
