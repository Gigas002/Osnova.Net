using System.Text.Json.Serialization;
using Osnova.Net.Responses.Blocks;

namespace Osnova.Net.Responses.BlockDatas
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
        public TelegramData TelegramData { get; set; }

        [JsonPropertyName("tg_data_encoded")]
        public string TelegramDataEncoded { get; set; }

        #endregion
    }
}
