using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Warning block
    /// <para/>
    /// <remarks>Editoral block</remarks>
    /// </summary>
    public class WarningBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public WarningBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="WarningBlock"/>
        /// </summary>
        public WarningBlock() : base(BlockType.Warning) { }

        /// <summary>
        /// Create <see cref="WarningBlock"/> with <see cref="WarningBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public WarningBlock(WarningBlockData data) : this() => Data = data;

        #endregion
    }
}