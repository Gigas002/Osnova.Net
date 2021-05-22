using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class TikTokBlockData
    {
        #region Properties

        [JsonPropertyName("tiktok")]
        public UniversalBoxBlock TikTok { get; set; }

        #endregion
    }
}
