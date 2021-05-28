using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Telegram block
    /// </summary>
    public class TelegramBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public TelegramBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="TelegramBlock"/>
        /// </summary>
        public TelegramBlock() : base(BlockType.Telegram) { }

        /// <summary>
        /// Create <see cref="TelegramBlock"/> with <see cref="TelegramBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public TelegramBlock(TelegramBlockData data) : this() => Data = data;

        #endregion
    }
}