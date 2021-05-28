using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    public class YandexMusicBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public YandexMusicBlockData Data { get; set; }

        #endregion

        #region Constructors

        public YandexMusicBlock() : base(BlockType.YaMusic) { }

        public YandexMusicBlock(YandexMusicBlockData data) : this() => Data = data;

        #endregion
    }
}