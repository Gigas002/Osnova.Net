using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class InstagramBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public InstagramBlockData Data { get; set; }

        #endregion

        #region Constructors

        public InstagramBlock() : base(BlockType.Instagram) { }

        public InstagramBlock(InstagramBlockData data) : this() => Data = data;

        #endregion
    }
}