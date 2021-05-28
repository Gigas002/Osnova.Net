using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Spotify's data in blocks
    /// </summary>
    public class SpotifyBlockData
    {
        #region Properties

        /// <summary>
        /// Universal block for external services
        /// </summary>
        [JsonPropertyName("spotify")]
        public UniversalBoxBlock Spotify { get; set; }

        #endregion
    }
}
