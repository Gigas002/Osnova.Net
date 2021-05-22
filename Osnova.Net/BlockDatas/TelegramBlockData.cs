using System.Text.Json.Serialization;
using Osnova.Net.Blocks;
using Osnova.Net.Telegram;

namespace Osnova.Net.BlockDatas
{
    public class TelegramBlockData
    {
        #region Properties

        [JsonPropertyName("telegram")]
        public TelegramBlock Telegram { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("markdown")]
        public string Markdown { get; set; }

        #region In telegram data

        [JsonPropertyName("tg_data")]
        public TelegramData TelegramData { get; set; }

        [JsonPropertyName("tg_data_encoded")]
        public string TelegramDataEncoded { get; set; }

        #endregion

        #endregion
    }
}
