using System.Text.Json.Serialization;
using Osnova.Net.Blocks;
using Osnova.Net.Telegram;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Telegram's data in blocks
    /// </summary>
    public class TelegramBlockData
    {
        #region Properties

        // In TelegramBlock's Data

        /// <summary>
        /// Block with link's data
        /// <para/>
        /// <remarks>Exists on higher level, e.g. TelegramBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("telegram")]
        public TelegramBlock Telegram { get; set; }

        /// <summary>
        /// Title
        /// <para/>
        /// <remarks>Exists on higher level, e.g. TelegramBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Markdown text
        /// <para/>
        /// <remarks>Exists on higher level, e.g. TelegramBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("markdown")]
        public string Markdown { get; set; }

        // In TelegramBlockData.Telegram.Data

        /// <summary>
        /// Data of telegram block
        /// <para/>
        /// <remarks>Refers to "tg_data" property in json</remarks>
        /// <para/>
        /// <remarks>Exists on lower level, e.g. TelegramBlock.Data.Telegram.Data</remarks>
        /// </summary>
        [JsonPropertyName("tg_data")]
        public TelegramData Data { get; set; }

        /// <summary>
        /// Encoded string of <see cref="Data"/>
        /// <para/>
        /// <remarks>Refers to "tg_data_encoded" property in json</remarks>
        /// <para/>
        /// <remarks>Exists on lower level, e.g. TelegramBlock.Data.Telegram.Data</remarks>
        /// </summary>
        [JsonPropertyName("tg_data_encoded")]
        public string DataEncoded { get; set; }

        #endregion
    }
}
