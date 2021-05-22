using System;
using System.Text.Json.Serialization;
using Osnova.Net.Blocks;
using Osnova.Net.JsonConverters;
using Osnova.Net.Twitter;

namespace Osnova.Net.BlockDatas
{
    public class TweetBlockData
    {
        [JsonPropertyName("tweet")]
        public TweetBlock Tweet { get; set; }

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
        public Tweet TweetData { get; set; }

        [JsonPropertyName("tweet_data_encoded")]
        public string TweetDataEncoded { get; set; }

        [JsonConverter(typeof(VersionJsonConverter))]
        [JsonPropertyName("version")]
        public Version Version { get; set; }

        #endregion
    }
}
