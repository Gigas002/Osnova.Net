using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class SpotifyBlockData
    {
        #region Properties

        [JsonPropertyName("spotify")]
        public UniversalBoxBlock Spotify { get; set; }

        #endregion
    }
}
