using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class WaterfallBlockData
    {
        #region Properties

        [JsonPropertyName("wtrfallid")]
        public string WaterfallId { get; set; }

        #endregion
    }
}
