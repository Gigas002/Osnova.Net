using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class ListBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public ListBlockData Data { get; set; }

        #endregion

        #region Constructors

        public ListBlock() : base(BlockType.List) { }

        public ListBlock(ListBlockData data) : this() => Data = data;

        #endregion
    }
}