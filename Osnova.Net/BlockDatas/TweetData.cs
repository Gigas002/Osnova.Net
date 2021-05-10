using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class TweetData
    {
        // TODO: implement it better someday

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("id_str")]
        public string IdString { get; set; }

        [JsonPropertyName("full_text")]
        public string FullText { get; set; }

        [JsonPropertyName("truncated")]
        public bool Truncated { get; set; }

        [JsonPropertyName("display_text_range")]
        public IEnumerable<int> DisplayTextRange { get; set; }

        [JsonPropertyName("entities")]
        public JsonElement Entities { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("in_reply_to_status_id")]
        public long? InReplyToStatusId { get; set; }

        [JsonPropertyName("in_reply_to_status_id_str")]
        public string InReplyToStatusIdString { get; set; }

        [JsonPropertyName("in_reply_to_user_id")]
        public long? InReplyToUserId { get; set; }

        [JsonPropertyName("in_reply_to_user_id_str")]
        public string InReplyToUserIdString { get; set; }

        [JsonPropertyName("in_reply_to_screen_name")]
        public long? InReplyToScreenName { get; set; }

        [JsonPropertyName("user")]
        public JsonElement User { get; set; }

        [JsonPropertyName("geo")]
        public JsonElement Geo { get; set; }

        [JsonPropertyName("coordinates")]
        public JsonElement Coorinates { get; set; }

        [JsonPropertyName("place")]
        public JsonElement Place { get; set; }

        [JsonPropertyName("contributors")]
        public JsonElement Contributors { get; set; }

        [JsonPropertyName("is_quote_status")]
        public bool IsQuoteStatus { get; set; }

        [JsonPropertyName("retweet_count")]
        public long RetweetCount { get; set; }

        [JsonPropertyName("favorite_count")]
        public long FavoriteCount { get; set; }

        [JsonPropertyName("favorited")]
        public bool Favorited { get; set; }

        [JsonPropertyName("retweeted")]
        public bool Retweeted { get; set; }

        [JsonPropertyName("possibly_sensitive")]
        public bool PossiblySensitive { get; set; }

        [JsonPropertyName("possibly_sensitive_appealable")]
        public bool PossiblySensitiveAppealable { get; set; }

        [JsonPropertyName("lang")]
        public string Lang { get; set; }

        [JsonPropertyName("extended_entities")]
        public JsonElement ExtendedEntities { get; set; }

        [JsonPropertyName("processed_text")]
        public string ProcessedText { get; set; }
    }
}
