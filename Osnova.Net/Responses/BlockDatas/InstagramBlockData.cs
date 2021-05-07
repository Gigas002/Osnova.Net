using System.Text.Json.Serialization;
using Osnova.Net.Responses.Blocks;

namespace Osnova.Net.Responses.BlockDatas
{
    public class InstagramBlockData : BlockData
    {
        [JsonPropertyName("instagram")]
        public Block Instagram { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("hide_title")]
        public bool HideTitle { get; set; }

        [JsonPropertyName("markdown")]
        public string Markdown { get; set; }
    }
}
