using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class RawHtmlBlockData : BlockData
    {
        [JsonPropertyName("raw")]
        public string Raw { get; set; }
    }
}
