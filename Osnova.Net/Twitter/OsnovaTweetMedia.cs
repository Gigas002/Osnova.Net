using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// OsnovaShit
    /// Used for GetTweets method only
    /// Refers to Tweetmedium spec
    /// </summary>
    public class OsnovaTweetMedia : TweetMedia
    {
        #region Properties

        #region Wrong data type

        // int != string
        [JsonPropertyName("type")]
        public new int Type { get; set; } // TODO: implement converter?

        #endregion

        [JsonPropertyName("thumbnail_url")]
        public Uri ThumbnailUrl { get; set; }

        [JsonPropertyName("thumbnail_width")]
        public int ThumbnailWidth { get; set; }

        [JsonPropertyName("thumbnail_height")]
        public int ThumbnailHeight { get; set; }

        [JsonPropertyName("ratio")]
        public double Ratio { get; set; }

        #endregion
    }
}
