using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class WaterfallBlockData : BlockData
    {
        [JsonPropertyName("wtrfallid")]
        public string WaterfallId { get; set; }
    }
}
