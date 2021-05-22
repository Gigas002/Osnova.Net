using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// OsnovaShit
    /// </summary>
    public class OsnovaTweetMedia
    {
        #region Properties

        #region Same as 1.1 spec TweetMedia

        // ok
        [JsonPropertyName("media_url")]
        public Uri MediaUrl { get; set; }

        #endregion

        #region Wrong data type

        // int != string
        [JsonPropertyName("type")]
        public int Type { get; set; }

        #endregion

        #region Wtf is this

        // nope
        [JsonPropertyName("thumbnail_url")]
        public Uri ThumbnailUrl { get; set; }

        // nope
        [JsonPropertyName("thumbnail_width")]
        public int ThumbnailWidth { get; set; }

        // nope
        [JsonPropertyName("thumbnail_height")]
        public int ThumbnailHeight { get; set; }

        // nope
        [JsonPropertyName("ratio")]
        public double Ratio { get; set; }

        #endregion

        #endregion
    }
}
