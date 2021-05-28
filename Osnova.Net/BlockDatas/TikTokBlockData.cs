using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// TikTok's data in blocks
    /// </summary>
    public class TikTokBlockData
    {
        #region Properties

        /// <summary>
        /// Universal block for external services
        /// </summary>
        [JsonPropertyName("tiktok")]
        public UniversalBoxBlock TikTok { get; set; }

        #endregion
    }
}
