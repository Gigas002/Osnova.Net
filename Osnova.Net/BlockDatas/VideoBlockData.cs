using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class VideoBlockData : BlockData
    {
        [JsonPropertyName("video")]
        public Block Video { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        #region Inside video block data

        [JsonPropertyName("thumbnail")]
        public Block Thumbnail { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("time")]
        public int Time { get; set; }

        [JsonPropertyName("external_service")]
        public ExternalService ExternalService { get; set; }

        #endregion
    }
}
