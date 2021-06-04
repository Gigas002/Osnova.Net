using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Tweet media's sizes
    /// <para/>
    /// <remarks>API version: 1.1;
    /// <para/>
    /// Doc src: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/entities
    /// </remarks>
    /// </summary>
    public class TweetMediaSizes
    {
        #region Properties

        /// <summary>
        /// Information for a thumbnail-sized version of the media
        /// <para/>
        /// <remarks>Refers to "thumb" property in json</remarks>
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
        
        #endregion
    }
}
