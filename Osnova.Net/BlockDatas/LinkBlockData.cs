using System;
using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class LinkBlockData
    {
        [JsonPropertyName("link")]
        public Block Link { get; set; }

        #region Inside link block data

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("image")]
        public Block Image { get; set; }

        [JsonPropertyName("v")]
        public int V { get; set; }

        #endregion
    }
}
