using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.BlockDatas
{
    public class UniversalBoxBlockData
    {
        #region Properties

        [JsonPropertyName("service")]
        public ExternalServiceType Service { get; set; }

        [JsonPropertyName("box_data")]
        public BoxData BoxData { get; set; }

        #endregion
    }
}
