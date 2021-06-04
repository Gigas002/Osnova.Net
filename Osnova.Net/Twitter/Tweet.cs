using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Usual tweet, used inside blocks
    /// <para/>
    /// <remarks>API version: 1.1;
    /// <para/>
    /// Doc source: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/tweet
    /// </remarks>
    /// </summary>
    public class Tweet
    {
        #region Properties

        /// <summary>
        /// UTC time when this Tweet was created
        /// <para/>
        /// <remarks>Example: Wed Oct 10 20:19:24 +0000 2018</remarks>
        /// </summary>
        [JsonConverter(typeof(TwitterV1DateTimeOffsetJsonConverter))]
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The integer representation of the unique identifier for this Tweet
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// The string representation of the unique identifier for this Tweet
        /// <para/>
        /// <remarks>Refers to "id_str" property in json</remarks>
        /// </summary>
        [JsonPropertyName("id_str")]
        public string IdString { get; set; }

        /// <summary>
        /// The actual UTF-8 text of the status update
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Utility used to post the Tweet, as an HTML-formatted string
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// Indicates whether the value of the text parameter was truncated, for example, as a
        /// result of a retweet exceeding the original Tweet text length limit of 140 characters
        /// </summary>
        [JsonPropertyName("truncated")]
        public bool Truncated { get; set; }

        /// <summary>
        /// If the represented Tweet is a reply, this field will contain the integer representation of the original Tweet’s ID
        /// <para/>
        /// <remarks>Nullable</remarks>
        /// </summary>
        [JsonPropertyName("in_reply_to_status_id")]
        public long? InReplyToStatusId { get; set; }

        /// <summary>
        /// If the represented Tweet is a reply, this field will contain the string representation of the original Tweet’s ID
        /// <para/>
        /// <remarks>Nullable</remarks>
        /// </summary>
        [JsonPropertyName("in_reply_to_status_id_str")]
        public string InReplyToStatusIdString { get; set; }

        /// <summary>
        /// If the represented Tweet is a reply, this field will contain the integer representation of the original Tweet’s author ID
        /// <para/>
        /// <remarks>Nullable</remarks>
        /// </summary>
        [JsonPropertyName("in_reply_to_user_id")]
        public long? InReplyToUserId { get; set; }

        /// <summary>
        /// If the represented Tweet is a reply, this field will contain the string representation of the original Tweet’s author ID
        /// <para/>
        /// <remarks>Nullable</remarks>
        /// </summary>
        [JsonPropertyName("in_reply_to_user_id_str")]
        public string InReplyToUserIdString { get; set; }

        /// <summary>
        /// If the represented Tweet is a reply, this field will contain the screen name of the original Tweet’s author
        /// <para/>
        /// <remarks>Nullable</remarks>
        /// </summary>
        [JsonPropertyName("in_reply_to_screen_name")]
        public string InReplyToScreenName { get; set; }

        /// <summary>
        /// The user who posted this Tweet
        /// </summary>
        [JsonPropertyName("user")]
        public TwitterUser User { get; set; }

        /// <summary>
        /// Represents the geographic location of this Tweet as reported by the user or client application
        /// <para/>
        /// <remarks>Nullable</remarks>
        /// </summary>
        [JsonPropertyName("coordinates")]
        public TwitterCoordinates<IEnumerable<float>> Coordinates { get; set; }

        /// <summary>
        /// When present, indicates that the tweet is associated (but not necessarily originating from) a Place
        /// <para/>
        /// <remarks>Nullable</remarks>
        /// </summary>
        [JsonPropertyName("place")]
        public TwitterPlace Place { get; set; }

        /// <summary>
        /// This field only surfaces when the Tweet is a quote Tweet. This field contains the integer value Tweet ID of the quoted Tweet
        /// </summary>
        [JsonPropertyName("quoted_status_id")]
        public long QuotedStatusId { get; set; }

        /// <summary>
        /// This field only surfaces when the Tweet is a quote Tweet. This is the string representation Tweet ID of the quoted Tweet
        /// </summary>
        [JsonPropertyName("quoted_status_id_str")]
        public string QuotedStatusIdString { get; set; }

        /// <summary>
        /// Indicates whether this is a Quoted Tweet
        /// </summary>
        [JsonPropertyName("is_quote_status")]
        public bool IsQuoteStatus { get; set; }

        /// <summary>
        /// This field only surfaces when the Tweet is a quote Tweet.
        /// This attribute contains the Tweet object of the original Tweet that was quoted
        /// </summary>
        [JsonPropertyName("quoted_status")]
        public Tweet QuotedStatus { get; set; }

        /// <summary>
        /// This attribute contains a representation of the original Tweet that was retweeted
        /// </summary>
        [JsonPropertyName("retweeted_status")]
        public Tweet RetweetedStatus { get; set; }

        /// <summary>
        /// Indicates approximately how many times this Tweet has been quoted by Twitter users
        /// <para/>
        /// <remarks>Nullable</remarks>
        /// </summary>
        [JsonPropertyName("quote_count")]
        public int? QuoteCount { get; set; }

        /// <summary>
        /// Number of times this Tweet has been replied to
        /// </summary>
        [JsonPropertyName("reply_count")]
        public int ReplyCount { get; set; }

        /// <summary>
        /// Number of times this Tweet has been retweeted
        /// </summary>
        [JsonPropertyName("retweet_count")]
        public int RetweetCount { get; set; }

        /// <summary>
        /// Indicates approximately how many times this Tweet has been liked by Twitter users
        /// <para/>
        /// <remarks>Nullable</remarks>
        /// </summary>
        [JsonPropertyName("favorite_count")]
        public int? FavoriteCount { get; set; }

        /// <summary>
        /// Entities which have been parsed out of the text of the Tweet
        /// </summary>
        [JsonPropertyName("entities")]
        public TwitterEntities Entities { get; set; }

        /// <summary>
        /// When between one and four native photos or one video or one animated GIF are in Tweet, contains an array 'media' metadata.
        /// This is also available in Quote Tweets
        /// </summary>
        [JsonPropertyName("extended_entities")]
        public TwitterEntities ExtendedEntities { get; set; }

        /// <summary>
        /// Indicates whether this Tweet has been liked by the authenticating user
        /// <para/>
        /// <remarks>Nullable</remarks>
        /// </summary>
        [JsonPropertyName("favorited")]
        public bool? Favorited { get; set; }

        /// <summary>
        /// Indicates whether this Tweet has been Retweeted by the authenticating user
        /// </summary>
        [JsonPropertyName("retweeted")]
        public bool Retweeted { get; set; }

        /// <summary>
        /// This field only surfaces when a Tweet contains a link.
        /// The meaning of the field doesn’t pertain to the Tweet content itself, but instead it is an
        /// indicator that the URL contained in the Tweet may contain content or media identified as sensitive content
        /// <para/>
        /// <remarks>Nullable</remarks>
        /// </summary>
        [JsonPropertyName("possibly_sensitive")]
        public bool? PossiblySensitive { get; set; }

        /// <summary>
        /// Indicates the maximum value of the filter_level parameter which may be used and still stream this Tweet.
        /// So a value of medium will be streamed on none, low, and medium streams
        /// </summary>
        [JsonPropertyName("filter_level")]
        public string FilterLevel { get; set; }

        /// <summary>
        /// When present, indicates a BCP 47 language identifier corresponding to the machine-detected
        /// language of the Tweet text, or und if no language could be detected
        /// <para/>
        /// <remarks>Refers to "lang" property in json
        /// <para/>
        /// Nullable</remarks>
        /// </summary>
        [JsonConverter(typeof(CultureInfoJsonConverter))]
        [JsonPropertyName("lang")]
        public CultureInfo Culture { get; set; }

        #region Enterprise only

        /// <summary>
        /// Present in filtered products such as Twitter Search and PowerTrack.
        /// Provides the id and tag associated with the rule that matched the Tweet
        /// </summary>
        [JsonPropertyName("matching_rules")]
        public IEnumerable<object> MatchingRules { get; set; }

        #endregion

        #region Additional tweet attributes

        /// <summary>
        /// Perspectival Only surfaces on methods supporting the include_my_retweet parameter, when set to true
        /// </summary>
        [JsonPropertyName("current_user_retweet")]
        public object CurrentUserRetweet { get; set; }

        /// <summary>
        /// A set of key-value pairs indicating the intended contextual delivery of the containing Tweet
        /// </summary>
        [JsonPropertyName("scopes")]
        public object Scopes { get; set; }

        /// <summary>
        /// When present and set to “true”, it indicates that this piece of content has been withheld due to a DMCA complaint
        /// </summary>
        [JsonPropertyName("withheld_copyright")]
        public bool WithheldCopyright { get; set; }

        /// <summary>
        /// When present, indicates a list of uppercase two-letter country codes this content is withheld from.
        /// Twitter supports the following non-country values for this field:
        /// “XX” - Content is withheld in all countries “XY” - Content is withheld due to a DMCA request
        /// </summary>
        [JsonPropertyName("withheld_in_countries")]
        public IEnumerable<string> WithheldInCountries { get; set; }

        /// <summary>
        /// When present, indicates whether the content being withheld is the “status” or a “user”
        /// </summary>
        [JsonPropertyName("withheld_scope")]
        public string WithheldScope { get; set; }

        #endregion

        #region Deprecated

        /// <summary>
        /// This deprecated attribute has its coordinates formatted as [lat, long], while all other Tweet geo is formatted as [long, lat].
        /// <para/>
        /// <remarks>Nullable</remarks>
        /// </summary>
        [Obsolete("Use the coordinates property instead")]
        [JsonPropertyName("geo")]
        public TwitterCoordinates<IEnumerable<float>> Geo { get; set; }

        #endregion

        #region Extended tweet (no docs)

        /// <summary>
        /// Full tweet's text
        /// </summary>
        [JsonPropertyName("full_text")]
        public string FullText { get; set; }

        /// <summary>
        /// Display text range
        /// </summary>
        [JsonPropertyName("display_text_range")]
        public IEnumerable<int> DisplayTextRange { get; set; }

        /// <summary>
        /// Contributors
        /// </summary>
        [JsonPropertyName("contributors")]
        public object Contributors { get; set; }

        /// <summary>
        /// Is this tweet possibly sensitive?
        /// </summary>
        [JsonPropertyName("possibly_sensitive_appealable")]
        public bool PossiblySensitiveAppealable { get; set; }

        /// <summary>
        /// Processed text
        /// </summary>
        [JsonPropertyName("processed_text")]
        public string ProcessedText { get; set; }

        #endregion

        #endregion
    }
}
