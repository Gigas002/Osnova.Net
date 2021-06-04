using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Osnova implementation of <see cref="TweetMedia"/> v 1.1;
    /// Used for GetTweets method only
    /// <para/>
    /// <remarks>Refers to Tweetmedium spec</remarks>
    /// </summary>
    public class OsnovaTweetMedia : TweetMedia
    {
        #region Properties

        #region Wrong data type

        /// <summary>
        /// Media type
        /// </summary>
        [JsonPropertyName("type")]
        public new int Type { get; set; } // TODO: implement converter? jpg = 1, youtube = 2

        #endregion

        /// <summary>
        /// Thumbnail URL
        /// </summary>
        [JsonPropertyName("thumbnail_url")]
        public Uri ThumbnailUrl { get; set; }

        /// <summary>
        /// Thumbnail's width
        /// </summary>
        [JsonPropertyName("thumbnail_width")]
        public int ThumbnailWidth { get; set; }

        /// <summary>
        /// Thumbnail's height
        /// </summary>
        [JsonPropertyName("thumbnail_height")]
        public int ThumbnailHeight { get; set; }

        /// <summary>
        /// Ratio
        /// </summary>
        [JsonPropertyName("ratio")]
        public double Ratio { get; set; }

        #endregion
    }
}
