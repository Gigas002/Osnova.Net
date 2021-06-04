using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Usual tweet's media
    /// <para/>
    /// <remarks>API version: 1.1;
    /// <para/>
    /// Doc src: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/entities
    /// </remarks>
    /// </summary>
    public class TweetMedia
    {
        #region Properties
        
        /// <summary>
        /// URL of the media to display to clients
        /// </summary>
        [JsonPropertyName("display_url")]
        public Uri DisplayUrl { get; set; }

        /// <summary>
        /// An expanded version of display_url. Links to the media display page
        /// </summary>
        [JsonPropertyName("expanded_url")]
        public Uri ExpandedUrl { get; set; }

        /// <summary>
        /// ID of the media expressed as a 64-bit integer
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// ID of the media expressed as a string
        /// </summary>
        [JsonPropertyName("id_str")]
        public string IdString { get; set; }

        /// <summary>
        /// An array of integers indicating the offsets within the Tweet text where the URL begins and ends
        /// </summary>
        [JsonPropertyName("indices")]
        public IEnumerable<int> Indices { get; set; }

        /// <summary>
        /// An http:// URL pointing directly to the uploaded media file
        /// </summary>
        [JsonPropertyName("media_url")]
        public Uri MediaUrl { get; set; }

        /// <summary>
        /// An https:// URL pointing directly to the uploaded media file, for embedding on https pages
        /// </summary>
        [JsonPropertyName("media_url_https")]
        public Uri MediaUrlHttps { get; set; }

        /// <summary>
        /// An object showing available sizes for the media file
        /// </summary>
        [JsonPropertyName("sizes")]
        public TweetMediaSizes Sizes { get; set; }

        /// <summary>
        /// Nullable. For Tweets containing media that was originally associated with a different tweet, this ID points to the original Tweet
        /// </summary>
        [JsonPropertyName("source_status_id")]
        public long? SourceStatusId { get; set; }

        /// <summary>
        /// Nullable. For Tweets containing media that was originally associated with a different tweet,
        /// this string-based ID points to the original Tweet
        /// </summary>
        [JsonPropertyName("source_status_id_str")]
        public string SourceStatusIdString { get; set; }

        /// <summary>
        /// Type of uploaded media. Possible types include photo, video, and animated_gif
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Wrapped URL for the media link. This corresponds with the URL embedded directly
        /// into the raw Tweet text, and the values for the indices parameter
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        /// <summary>
        /// Video's info
        /// </summary>
        [JsonPropertyName("video_info")]
        public TwitterVideoInfo VideoInfo { get; set; }

        /// <summary>
        /// Additional media info
        /// </summary>
        [JsonPropertyName("additional_media_info")]
        public TwitterAdditionalMediaInfo AdditionalMediaInfo { get; set; }
        
        #endregion
    }
}
