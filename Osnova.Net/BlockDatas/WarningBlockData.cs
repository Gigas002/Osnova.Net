using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class WarningBlockData
    {
        #region Properties

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        #endregion
    }
}
