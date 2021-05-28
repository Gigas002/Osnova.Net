using System.Text.Json.Serialization;
using Osnova.Net.Entries;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class EntryBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public Entry Data { get; set; }

        #endregion

        #region Constructors

        public EntryBlock() : base(BlockType.Entry) { }

        public EntryBlock(Entry data) : this() => Data = data;

        #endregion
    }
}