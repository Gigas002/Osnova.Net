using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Inside InstagramBlockData, SpotifyBlockData, TikTokBlockData, YaMusicBlockData
    /// </summary>
    public class UniversalBoxBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public UniversalBoxBlockData Data { get; set; }

        #endregion

        #region Constructors

        public UniversalBoxBlock() : base(BlockType.UniversalBox) { }

        public UniversalBoxBlock(UniversalBoxBlockData data) : this() => Data = data;

        #endregion
    }
}