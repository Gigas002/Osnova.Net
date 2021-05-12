using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class UniversalBoxBlockData
    {
        [JsonPropertyName("service")]
        public string Service { get; set; }

        [JsonPropertyName("box_data")]
        public BoxData BoxData { get; set; }
    }
}
