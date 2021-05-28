using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Yandex music block
    /// </summary>
    public class YandexMusicBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public YandexMusicBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="YandexMusicBlock"/>
        /// </summary>
        public YandexMusicBlock() : base(BlockType.YandexMusic) { }

        /// <summary>
        /// Create <see cref="YandexMusicBlock"/> with <see cref="YandexMusicBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public YandexMusicBlock(YandexMusicBlockData data) : this() => Data = data;

        #endregion
    }
}