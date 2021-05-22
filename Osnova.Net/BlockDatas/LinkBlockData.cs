using System;
using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class LinkBlockData
    {
        #region Properties

        [JsonPropertyName("link")]
        public LinkBlock Link { get; set; }

        #region Inside link block data

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("image")]
        public ImageBlock Image { get; set; }

        [JsonPropertyName("v")]
        public int V { get; set; } // TODO: wtf is "v"? version?

        #endregion

        #endregion
    }
}
