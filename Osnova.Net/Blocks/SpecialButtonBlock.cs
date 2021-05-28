using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Special button block
    /// <para/>
    /// <remarks>Editoral block</remarks>
    /// </summary>
    public class SpecialButtonBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public SpecialButtonBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="SpecialButtonBlock"/>
        /// </summary>
        public SpecialButtonBlock() : base(BlockType.SpecialButton) { }

        /// <summary>
        /// Create <see cref="SpecialButtonBlock"/> with <see cref="SpecialButtonBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public SpecialButtonBlock(SpecialButtonBlockData data) : this() => Data = data;

        #endregion
    }
}