using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
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

        [JsonPropertyName("tweet_data")]
        public TweetData TweetData { get; set; }

        [JsonPropertyName("tweet_data_encoded")]
        public string TweetDataEncoded { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        #endregion
    }
}
