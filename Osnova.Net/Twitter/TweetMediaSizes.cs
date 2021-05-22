using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// </summary>
    public class TweetMediaSizes
    {
        [JsonPropertyName("thumb")]
        public TweetMediaSize Thumbnail { get; set; }

        [JsonPropertyName("large")]
        public TweetMediaSize Large { get; set; }

        [JsonPropertyName("medium")]
        public TweetMediaSize Medium { get; set; }

        [JsonPropertyName("small")]
        public TweetMediaSize Small { get; set; }
    }
}
