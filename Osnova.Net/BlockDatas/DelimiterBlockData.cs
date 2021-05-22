using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.BlockDatas
{
    public class DelimiterBlockData
    {
        #region Properties

        [JsonPropertyName("type")]
        public DelimiterType Type { get; set; }

        #endregion
    }
}
