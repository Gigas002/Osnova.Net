using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class TelegramBlockData : BlockData
    {
        [JsonPropertyName("telegram")]
        public Block Telegram { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("markdown")]
        public string Markdown { get; set; }

        #region In telegram data

        [JsonPropertyName("tg_data")]
        public object TelegramData { get; set; } // TODO: telegram data

        [JsonPropertyName("tg_data_encoded")]
        public string TelegramDataEncoded { get; set; }

        #endregion
    }
}
