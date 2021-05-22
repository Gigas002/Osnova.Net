using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class TelegramBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public TelegramBlockData Data { get; set; }

        #endregion

        #region Constructors

        public TelegramBlock() : base(BlockType.Telegram) { }

        public TelegramBlock(TelegramBlockData data) : this() => Data = data;

        #endregion
    }
}