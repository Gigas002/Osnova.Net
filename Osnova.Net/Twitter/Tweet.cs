using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// </summary>
    public class Tweet
    {
        #region Properties

        [JsonConverter(typeof(TwitterV1DateTimeOffsetJsonConverter))]
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("id_str")]
        public string IdString { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("truncated")]
        public bool Truncated { get; set; }

        [JsonPropertyName("in_reply_to_status_id")]
        public long? InReplyToStatusId { get; set; }

        [JsonPropertyName("in_reply_to_status_id_str")]
        public string InReplyToStatusIdString { get; set; }

        [JsonPropertyName("in_reply_to_user_id")]
        public long? InReplyToUserId { get; set; }

        [JsonPropertyName("in_reply_to_user_id_str")]
        public string InReplyToUserIdString { get; set; }

        [JsonPropertyName("in_reply_to_screen_name")]
        public string InReplyToScreenName { get; set; }

        [JsonPropertyName("user")]
        public TwitterUser User { get; set; }

        [JsonPropertyName("coordinates")]
        public TwitterCoordinates Coordinates { get; set; }

        [JsonPropertyName("place")]
        public TwitterPlace Place { get; set; }

        [JsonPropertyName("quoted_status_id")]
        public long QuotedStatusId { get; set; }

        [JsonPropertyName("quoted_status_id_str")]
        public string QuotedStatusIdString { get; set; }

        [JsonPropertyName("is_quote_status")]
        public bool IsQuoteStatus { get; set; }

        [JsonPropertyName("quoted_status")]
        public Tweet QuotedStatus { get; set; }

        [JsonPropertyName("retweeted_status")]
        public Tweet RetweetedStatus { get; set; }

        [JsonPropertyName("quote_count")]
        public int? QuoteCount { get; set; }

        [JsonPropertyName("reply_count")]
        public int ReplyCount { get; set; }

        [JsonPropertyName("retweet_count")]
        public int RetweetCount { get; set; }

        [JsonPropertyName("favorite_count")]
        public int? FavoriteCount { get; set; }

        [JsonPropertyName("entities")]
        public TwitterEntities Entities { get; set; }

        [JsonPropertyName("extended_entities")]
        public TwitterExtendedEntities ExtendedEntities { get; set; }

        [JsonPropertyName("favorited")]
        public bool? Favorited { get; set; }

        [JsonPropertyName("retweeted")]
        public bool Retweeted { get; set; }

        [JsonPropertyName("possibly_sensitive")]
        public bool? PossiblySensitive { get; set; }

        [JsonPropertyName("filter_level")]
        public string FilterLevel { get; set; }

        [JsonPropertyName("lang")]
        public string Language { get; set; }

        [JsonPropertyName("matching_rules")]
        public IEnumerable<object> MatchingRules { get; set; }

        #region Additional tweet attributes

        [JsonPropertyName("current_user_retweet")]
        public object CurrentUserRetweet { get; set; }

        [JsonPropertyName("scopes")]
        public object Scopes { get; set; }

        [JsonPropertyName("withheld_copyright")]
        public bool WithheldCopyright { get; set; }

        [JsonPropertyName("withheld_in_countries")]
        public IEnumerable<string> WithheldInCountries { get; set; }

        [JsonPropertyName("withheld_scope")]
        public string WithheldScope { get; set; }

        #endregion

        #region Deprecated

        /// <summary>
        /// Obsolete. See twitter api reference for details:
        /// </summary>
        [Obsolete("Use coordinates instead")]
        [JsonPropertyName("geo")]
        public TwitterCoordinates Geo { get; set; }

        #endregion

        #region Possibly deprecated

        /// <summary>
        /// extended tweet
        /// </summary>
        [JsonPropertyName("full_text")]
        public string FullText { get; set; }

        /// <summary>
        /// extended tweet
        /// </summary>
        [JsonPropertyName("display_text_range")]
        public IEnumerable<int> DisplayTextRange { get; set; }

        /// <summary>
        /// extended tweet
        /// </summary>
        [JsonPropertyName("contributors")]
        public object Contributors { get; set; }

        /// <summary>
        /// extended tweet
        /// </summary>
        [JsonPropertyName("possibly_sensitive_appealable")]
        public bool PossiblySensitiveAppealable { get; set; }

        [JsonPropertyName("processed_text")]
        public string ProcessedText { get; set; }

        #endregion

        #endregion
    }
}
