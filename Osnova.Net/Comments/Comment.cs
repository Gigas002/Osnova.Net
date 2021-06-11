using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Blocks;
using Osnova.Net.Entries;
using Osnova.Net.Enums;
using Osnova.Net.JsonConverters;
using Osnova.Net.Popular;
using Osnova.Net.Users;

namespace Osnova.Net.Comments
{
    /// <inheritdoc cref="IComment"/>
    public class Comment : IComment
    {
        #region Properties

        #region IComment implementation

        /// <inheritdoc />
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <inheritdoc />
        /// <para/>
        /// <remarks>Refers to "date" [rp[erty in json</remarks>
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("date")]
        public DateTimeOffset DateCreated { get; set; }

        /// <inheritdoc />
        /// <para/>
        /// <remarks>Refers to "dateRFC" [rp[erty in json</remarks>
        [JsonConverter(typeof(RfcDateTimeOffsetJsonConverter))]
        [JsonPropertyName("dateRFC")]
        public DateTimeOffset DateCreatedRfc { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("author")]
        public User Author { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <inheritdoc />
        /// <para/>
        /// <remarks>Refers to "text_wo_md" [rp[erty in json</remarks>
        [JsonPropertyName("text_wo_md")]
        public string MarkdownText { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("media")]
        public IEnumerable<CommentMedia> Media { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("likes")]
        public Likes Likes { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("entry")]
        public Entry Entry { get; set; }

        /// <inheritdoc />
        /// <para/>
        /// <remarks>Refers to "replyTo" [rp[erty in json</remarks>
        [JsonPropertyName("replyTo")]
        public int ReplyToId { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("isFavorited")]
        public bool IsFavorited { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("is_pinned")]
        public bool IsPinned { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("isEdited")]
        public bool IsEdited { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("level")]
        public int Level { get; set; }

        /// <inheritdoc />
        /// <para/>
        /// <remarks>Refers to "source_id" [rp[erty in json</remarks>
        [JsonPropertyName("source_id")]
        public SourceOs SourceOs { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("load_more")]
        public CommentsLoadMore LoadMore { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("attaches")]
        public IEnumerable<Block> Attachments { get; set; }

        /// <inheritdoc />
        /// <para/>
        /// <remarks>Refers to "etcControls" [rp[erty in json</remarks>
        [JsonPropertyName("etcControls")]
        public AdditionalControls AdditionalControls { get; set; }

        #endregion

        #region From actual queries

        /// <summary>
        /// Date, when this comment was favorited
        /// </summary>
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("date_favorite")]
        public DateTimeOffset DateFavorited { get; set; }

        /// <summary>
        /// Is this comment ignored?
        /// </summary>
        [JsonPropertyName("is_ignored")]
        public bool IsIgnored { get; set; }

        /// <summary>
        /// Is this comment removed?
        /// </summary>
        [JsonPropertyName("is_removed")]
        public bool IsRemoved { get; set; }

        /// <summary>
        /// HTML version of this comment
        /// </summary>
        [JsonPropertyName("html")]
        public string Html { get; set; }

        /// <summary>
        /// Highlight
        /// </summary>
        [JsonPropertyName("highlight")]
        public string Highlight { get; set; }

        /// <summary>
        /// Donate vslue, if this is a donate comment
        /// </summary>
        [JsonPropertyName("donate")]
        public Counter Donate { get; set; }

        #endregion

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Gets default comment URL
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/comment</returns>
        public static Uri GetDefaultCommentUrl(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/comment");
        }

        #region GET

        #region Shortcuts in another classes

        /// <inheritdoc cref="Osnova.Net.Entries.Entry.GetCommentsAsync"/>
        public static ValueTask<IEnumerable<Comment>> GetEntryCommentsAsync(HttpClient client, WebsiteKind websiteKind, int entryId,
                                                                            CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            return Entry.GetCommentsAsync(client, websiteKind, entryId, sorting, apiVersion);
        }

        /// <inheritdoc cref="Osnova.Net.Entries.Entry.GetCommentsThreadsAsync"/>
        public static ValueTask<CommentThreads> GetEntryCommentsThreadsAsync(HttpClient client, WebsiteKind websiteKind, int entryId,
                                                                             CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            return Entry.GetCommentsThreadsAsync(client, websiteKind, entryId, sorting, apiVersion);
        }

        /// <inheritdoc cref="Osnova.Net.Entries.Entry.GetCommentThreadAsync"/>
        public static ValueTask<CommentThreads> GetEntryCommentThreadAsync(HttpClient client, WebsiteKind websiteKind, int entryId,
                                                                           int commentId, double apiVersion = Core.ApiVersion)
        {
            return Entry.GetCommentThreadAsync(client, websiteKind, entryId, commentId, apiVersion);
        }

        #endregion

        #region GetCommentLikers

        /// <summary>
        /// Gets an URL to get likers of specified comment
        /// <para/>
        /// <remarks>Original name: getCommentLikersUri</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="commentId">Comment id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/comment/likers/0</returns>
        public static Uri GetCommentLikersUri(WebsiteKind websiteKind, int commentId, double apiVersion = Core.ApiVersion)
        {
            var relative = $"likers/{commentId}";

            var baseUri = GetDefaultCommentUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/{relative}");
        }

        /// <inheritdoc cref="GetCommentLikersAsync"/>
        public static ValueTask<HttpResponseMessage> GetCommentLikersResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int commentId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetCommentLikersUri(websiteKind, commentId, apiVersion));
        }

        /// <summary>
        /// Gets likers for specified comment
        /// <para/>
        /// <remarks>Original name: getCommentLikersUri</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="commentId">Comment id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested likers</returns>
        public static async ValueTask<Dictionary<long, Liker>> GetCommentLikersAsync(HttpClient client, WebsiteKind websiteKind,
                                                                            int commentId, double apiVersion = Core.ApiVersion)
        {
            var response = await GetCommentLikersResponseAsync(client, websiteKind, commentId, apiVersion).ConfigureAwait(false);

            // TODO: long? What is this long stands for? User's id?
            return await Core.DeserializeOsnovaResponseAsync<Dictionary<long, Liker>>(response).ConfigureAwait(false);
        }

        #endregion

        // TODO: consider moving to Popular class with shortcut method from here

        #region GetPopular

        /// <summary>
        /// Gets an URL to get most popular entries and comments
        /// <para/>
        /// <remarks>Original name: getEntryWidgets</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/entry/0/widgets</returns>
        public static Uri GetPopularUri(WebsiteKind websiteKind, int entryId, double apiVersion = Core.ApiVersion)
        {
            var relative = $"{entryId}/widgets";

            var baseUri = Entry.GetDefaultEntryUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/{relative}");
        }

        /// <inheritdoc cref="GetPopularAsync"/>
        public static ValueTask<HttpResponseMessage> GetPopularResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int entryId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetPopularUri(websiteKind, entryId, apiVersion));
        }

        /// <summary>
        /// Gets popular entries and comments
        /// <para/>
        /// <remarks>Original name: getEntryWidgets</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested popular entries and comments</returns>
        public static async ValueTask<IEnumerable<PopularBase>> GetPopularAsync(HttpClient client, WebsiteKind websiteKind,
            int entryId, double apiVersion = Core.ApiVersion)
        {
            var response = await GetPopularResponseAsync(client, websiteKind, entryId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<PopularBase>>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }
}