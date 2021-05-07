using System.Text.Json.Serialization;
using Osnova.Net.Responses.Blocks;

namespace Osnova.Net.Responses.BlockDatas
{
    public class TikTokBlockData : BlockData
    {
        [JsonPropertyName("tiktok")]
        public Block TikTok { get; set; }
    }
}
