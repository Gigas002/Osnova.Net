using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class PersonBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public PersonBlockData Data { get; set; }

        #endregion

        #region Constructors

        public PersonBlock() : base(BlockType.Person) { }

        public PersonBlock(PersonBlockData data) : this() => Data = data;

        #endregion
    }
}