using System.Text.Json.Serialization;
using Osnova.Net.Responses.Blocks;

namespace Osnova.Net.Responses.BlockDatas
{
    public class TweetBlockData : BlockData
    {
        [JsonPropertyName("tweet")]
        public Block Tweet { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("media")]
        public bool Media { get; set; }

        [JsonPropertyName("conversation")]
        public bool Conversation { get; set; }

        [JsonPropertyName("markdown")]
        public string Markdown { get; set; }

        #region In tweet block data

        public TweetData TweetData { get; set; }

        public string TweetDataEncoded { get; set; }

        public string Version { get; set; }

        #endregion
    }
}
