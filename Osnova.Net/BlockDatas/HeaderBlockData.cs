using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.BlockDatas
{
    public class HeaderBlockData
    {
        #region Properties

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("style")]
        public HeaderStyle Style { get; set; }

        #endregion
    }
}
