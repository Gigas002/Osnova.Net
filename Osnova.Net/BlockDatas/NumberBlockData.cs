using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class NumberBlockData
    {
        #region Properties

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        #endregion
    }
}
