using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class RawHtmlBlockData
    {
        [JsonPropertyName("raw")]
        public string Raw { get; set; }
    }
}
