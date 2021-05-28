using System.Text.Json.Serialization;
using Osnova.Net.Entries;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Block with entry in it
    /// </summary>
    public class EntryBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public Entry Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="EntryBlock"/>
        /// </summary>
        public EntryBlock() : base(BlockType.Entry) { }

        /// <summary>
        /// Create <see cref="EntryBlock"/> with <see cref="Entry"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public EntryBlock(Entry data) : this() => Data = data;

        #endregion
    }
}