using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Blocks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Comment
    {
        #region From getEntryById -> commentsPreview docs

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("date")]
        public long Date { get; set; }

        [JsonPropertyName("dateRFC")]
        public string DateRFC { get; set; }

        [JsonPropertyName("author")]
        public User Author { get; set; }

        /// <summary>
        /// Текст комментария с html
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Текст комментария с markdown
        /// </summary>
        [JsonPropertyName("text_wo_md")]
        public string MarkdownText { get; set; }

        [JsonPropertyName("media")]
        public IEnumerable<Media> Media { get; set; }

        [JsonPropertyName("likes")]
        public Likes Likes { get; set; }

        [JsonPropertyName("entry")]
        public Entry Entry { get; set; }

        [JsonPropertyName("replyTo")]
        public long ReplyTo { get; set; }

        [JsonPropertyName("isFavorited")]
        public bool IsFavorited { get; set; }

        [JsonPropertyName("is_pinned")]
        public bool IsPinned { get; set; }

        [JsonPropertyName("isEdited")]
        public bool IsEdited { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }

        /// <summary>
        /// С какой OS был написан комментарий:
        /// Other = 0
        /// iOS = 1
        /// Android = 2
        /// </summary>
        [JsonPropertyName("source_id")]
        public SourceOs SourceOs { get; set; }

        [JsonPropertyName("load_more")]
        public LoadMore LoadMore { get; set; }

        [JsonPropertyName("attaches")]
        public IEnumerable<Block> Attaches { get; set; }

        [JsonPropertyName("etcControls")]
        public EtcControls EtcControls { get; set; }

        [JsonPropertyName("date_favorite")]
        public long? DateFavorited { get; set; }

        [JsonPropertyName("is_ignored")]
        public bool IsIgnored { get; set; }

        [JsonPropertyName("is_removed")]
        public bool IsRemoved { get; set; }

        [JsonPropertyName("html")]
        public string Html { get; set; }

        [JsonPropertyName("highlight")]
        public string Highlight { get; set; }

        [JsonPropertyName("donate")]
        public Counter Donate { get; set; }

        #endregion

        #region Methods

        #region GetEntryComments

        public static Uri GetEntryCommentsUri(WebsiteKind websiteKind, int entryId, CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/entry/{entryId}/comments/{sorting}");
        }

        public static ValueTask<HttpResponseMessage> GetEntryCommentsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int entryId, CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetEntryCommentsUri(websiteKind, entryId, sorting, apiVersion));
        }

        public static async ValueTask<IEnumerable<Comment>> GetEntryCommentsAsync(HttpClient client, WebsiteKind websiteKind, int entryId,
            CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            var response = await GetEntryCommentsResponseAsync(client, websiteKind, entryId, sorting, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Comment>>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion
    }
}