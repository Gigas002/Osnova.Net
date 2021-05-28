using System;
using System.Text.Json.Serialization;
using Osnova.Net.Blocks;
using Osnova.Net.JsonConverters;
using Osnova.Net.Twitter;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Tweet in block
    /// </summary>
    public class TweetBlockData
    {
        #region Properties

        // In TweetBlock's Data

        /// <summary>
        /// Block with actual block's data
        /// <para/>
        /// <remarks>Exists on higher level, e.g. TweetBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("tweet")]
        public TweetBlock Tweet { get; set; }

        /// <summary>
        /// Title
        /// <para/>
        /// <remarks>Exists on higher level, e.g. TweetBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Has media?
        /// <para/>
        /// <remarks>Refers to "media" property in json</remarks>
        /// <para/>
        /// <remarks>Exists on higher level, e.g. TweetBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("media")]
        public bool HasMedia { get; set; }

        /// <summary>
        /// Has conversation?
        /// <para/>
        /// <remarks>Refers to "conversation" property in json</remarks>
        /// <para/>
        /// <remarks>Exists on higher level, e.g. TweetBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("conversation")]
        public bool HasConversation { get; set; }

        /// <summary>
        /// Tweet's text as markdown
        /// <para/>
        /// <remarks>Exists on higher level, e.g. TweetBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("markdown")]
        public string Markdown { get; set; }

        // In TweetBlockData.Tweet.Data

        /// <summary>
        /// Actual data from twitter
        /// <para/>
        /// <remarks>Uses twitter's API ver. 1.1</remarks>
        /// <para/>
        /// <remarks>Refers to "tweet_data" property in json</remarks>
        /// <para/>
        /// <remarks>Exists on lower level, e.g. TweetBlockData.Tweet.Data</remarks>
        /// </summary>
        [JsonPropertyName("tweet_data")]
        public Tweet Data { get; set; }

        /// <summary>
        /// Tweet's text encoded
        /// <para/>
        /// <remarks>Refers to "tweet_data_encoded" property in json</remarks>
        /// <para/>
        /// <remarks>Exists on lower level, e.g. TweetBlockData.Tweet.Data</remarks>
        /// </summary>
        [JsonPropertyName("tweet_data_encoded")]
        public string DataEncoded { get; set; }

        /// <summary>
        /// Version
        /// <para/>
        /// <remarks>Exists on lower level, e.g. TweetBlockData.Tweet.Data</remarks>
        /// </summary>
        [JsonConverter(typeof(VersionJsonConverter))]
        [JsonPropertyName("version")]
        public Version Version { get; set; }

        #endregion
    }
}
