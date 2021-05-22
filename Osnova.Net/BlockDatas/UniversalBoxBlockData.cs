using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.BlockDatas
{
    public class UniversalBoxBlockData
    {
        #region Properties

        [JsonPropertyName("service")]
        public Service Service { get; set; }

        [JsonPropertyName("box_data")]
        public BoxData BoxData { get; set; }

        #endregion
    }
}
