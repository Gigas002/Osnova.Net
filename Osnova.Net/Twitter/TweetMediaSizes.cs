using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// Doc src: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/entities
    /// </summary>
    public class TweetMediaSizes
    {
        /// <summary>
        /// Information for a thumbnail-sized version of the media
        /// </summary>
        [JsonPropertyName("thumb")]
        public TweetMediaSize Thumbnail { get; set; }

        /// <summary>
        /// Information for a large-sized version of the media
        /// </summary>
        [JsonPropertyName("large")]
        public TweetMediaSize Large { get; set; }

        /// <summary>
        /// Information for a medium-sized version of the media
        /// </summary>
        [JsonPropertyName("medium")]
        public TweetMediaSize Medium { get; set; }

        /// <summary>
        /// Information for a small-sized version of the media
        /// </summary>
        [JsonPropertyName("small")]
        public TweetMediaSize Small { get; set; }
    }
}
