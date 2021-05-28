using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Blocks;
using Osnova.Net.Entries;
using Osnova.Net.Enums;

namespace Osnova.Net.Comments
{
    public class Comment
    {
        #region Properties

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
        public IEnumerable<CommentMedia> Media { get; set; }

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
        public CommentsLoadMore LoadMore { get; set; }

        [JsonPropertyName("attaches")]
        public IEnumerable<Block> Attaches { get; set; }

        [JsonPropertyName("etcControls")]
        public AdditionalControls EtcControls { get; set; }

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

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion

        #region Methods

        #region GetEntryComments

        public static Uri GetEntryCommentsUri(WebsiteKind websiteKind, int entryId, CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/entry/{entryId}/comments/{sorting.ToString().ToLowerInvariant()}");
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

        #region GetEntryCommentsLevels

        public static Uri GetEntryCommentsLevelsUri(WebsiteKind websiteKind, int entryId, CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/entry/{entryId}/comments/levels/{sorting.ToString().ToLowerInvariant()}");
        }

        public static ValueTask<HttpResponseMessage> GetEntryCommentsLevelsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int entryId, CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetEntryCommentsLevelsUri(websiteKind, entryId, sorting, apiVersion));
        }

        public static async ValueTask<CommentThreads> GetEntryCommentsLevelsAsync(HttpClient client, WebsiteKind websiteKind, int entryId,
            CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            var response = await GetEntryCommentsLevelsResponseAsync(client, websiteKind, entryId, sorting, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<CommentThreads>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetEntryCommentsThread

        public static Uri GetEntryCommentsThreadUri(WebsiteKind websiteKind, int entryId, long commentId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/entry/{entryId}/comments/thread/{commentId}");
        }

        public static ValueTask<HttpResponseMessage> GetEntryCommentsThreadResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int entryId, long commentId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetEntryCommentsThreadUri(websiteKind, entryId, commentId, apiVersion));
        }

        public static async ValueTask<CommentThreads> GetEntryCommentsThreadAsync(HttpClient client, WebsiteKind websiteKind, int entryId,
            long commentId, double apiVersion = Core.ApiVersion)
        {
            var response = await GetEntryCommentsThreadResponseAsync(client, websiteKind, entryId, commentId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<CommentThreads>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetCommentLikers

        public static Uri GetCommentLikersUri(WebsiteKind websiteKind, long commentId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/comment/likers/{commentId}");
        }

        public static ValueTask<HttpResponseMessage> GetCommentLikersResponseAsync(HttpClient client, WebsiteKind websiteKind,
            long commentId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetCommentLikersUri(websiteKind, commentId, apiVersion));
        }

        public static async ValueTask<Dictionary<long, Liker>> GetCommentLikersAsync(HttpClient client, WebsiteKind websiteKind,
                                                                            long commentId, double apiVersion = Core.ApiVersion)
        {
            var response = await GetCommentLikersResponseAsync(client, websiteKind, commentId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Dictionary<long, Liker>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetEntryWidgets

        public static Uri GetEntryWidgetsUri(WebsiteKind websiteKind, long entryId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/entry/{entryId}/widgets");
        }

        public static ValueTask<HttpResponseMessage> GetEntryWidgetsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            long entryId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetEntryWidgetsUri(websiteKind, entryId, apiVersion));
        }

        public static async ValueTask<IEnumerable<Widget>> GetEntryWidgetsAsync(HttpClient client, WebsiteKind websiteKind,
            long entryId, double apiVersion = Core.ApiVersion)
        {
            var response = await GetEntryWidgetsResponseAsync(client, websiteKind, entryId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Widget>>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion
    }
}