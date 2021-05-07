using System.Text.Json.Serialization;

namespace Osnova.Net.Responses.BlockDatas
{
    public class WaterfallBlockData : BlockData
    {
        [JsonPropertyName("wtrfallid")]
        public string WaterfallId { get; set; }
    }
}
