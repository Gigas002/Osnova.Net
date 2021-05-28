using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.BlockDatas
{
    public class IncutBlockData
    {
        #region Properties

        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Refers to type
        /// </summary>
        [JsonPropertyName("type")]
        public Alignment TextAlignment { get; set; }

        [JsonPropertyName("text_size")]
        public TextSize TextSize { get; set; }

        #endregion
    }
}
