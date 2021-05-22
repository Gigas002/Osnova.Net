using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// Doc src: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/entities
    /// </summary>
    public class TweetMediaSize
    {
        /// <summary>
        /// Width in pixels of this size
        /// </summary>
        [JsonPropertyName("w")]
        public int Width { get; set; }

        /// <summary>
        /// Height in pixels of this size
        /// </summary>
        [JsonPropertyName("h")]
        public int Height { get; set; }

        /// <summary>
        /// Resizing method used to obtain this size. A value of fit means that the media was
        /// resized to fit one dimension, keeping its native aspect ratio. A value of crop means
        /// that the media was cropped in order to fit a specific resolution
        /// </summary>
        [JsonPropertyName("resize")]
        public string Resize { get; set; }
    }
}
