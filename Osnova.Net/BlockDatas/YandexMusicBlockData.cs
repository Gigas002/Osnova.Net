using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Yandex music's data in blocks
    /// </summary>
    public class YandexMusicBlockData
    {
        #region Properties

        /// <summary>
        /// Universal block for external services
        /// <para/>
        /// <remarks>Refers to "yamusic" property in json</remarks>
        /// </summary>
        [JsonPropertyName("yamusic")]
        public UniversalBoxBlock YandexMusic { get; set; }

        #endregion
    }
}
