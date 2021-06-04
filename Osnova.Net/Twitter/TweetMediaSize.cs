using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Tweet media's size
    /// <para/>
    /// <remarks>API version: 1.1;
    /// <para/>
    /// Doc src: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/entities
    /// </remarks>
    /// </summary>
    public class TweetMediaSize
    {
        #region Properties
        
        /// <summary>
        /// Width in pixels of this size
        /// <para/>
        /// <remarks>Refers to "w" property in json</remarks>
        /// </summary>
        [JsonPropertyName("w")]
        public int Width { get; set; }

        /// <summary>
        /// Height in pixels of this size
        /// <para/>
        /// <remarks>Refers to "h" property in json</remarks>
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
        
        #endregion
    }
}
