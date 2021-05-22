using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class InstagramBlockData
    {
        #region Properties

        [JsonPropertyName("instagram")]
        public UniversalBoxBlock Instagram { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("hide_title")]
        public bool HideTitle { get; set; }

        [JsonPropertyName("markdown")]
        public string Markdown { get; set; }

        #endregion
    }
}
