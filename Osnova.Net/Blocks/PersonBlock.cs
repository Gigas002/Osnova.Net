using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Person block
    /// </summary>
    public class PersonBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public PersonBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="PersonBlock"/>
        /// </summary>
        public PersonBlock() : base(BlockType.Person) { }

        /// <summary>
        /// Create <see cref="PersonBlock"/> with <see cref="PersonBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public PersonBlock(PersonBlockData data) : this() => Data = data;

        #endregion
    }
}