using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class RawHtmlBlockData
    {
        #region Properties

        [JsonPropertyName("raw")]
        public string Raw { get; set; }

        #endregion
    }
}
