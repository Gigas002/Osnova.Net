using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class YandexMusicBlockData
    {
        #region Properties

        [JsonPropertyName("yamusic")]
        public UniversalBoxBlock YaMusic { get; set; }

        #endregion
    }
}
