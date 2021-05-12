using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class TikTokBlockData
    {
        [JsonPropertyName("tiktok")]
        public Block TikTok { get; set; }
    }
}
