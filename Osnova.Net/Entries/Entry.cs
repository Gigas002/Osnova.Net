using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Blocks;
using Osnova.Net.Comments;
using Osnova.Net.Enums;
using Osnova.Net.JsonConverters;
using Osnova.Net.Users;

namespace Osnova.Net.Entries
{
    /// <summary>
    /// Entry or "post" on osnova websites
    /// <para/>
    /// <remarks>Includes implementation of official Entry docs
    /// and properties from actual queries</remarks>
    /// </summary>
    public class Entry : IEntry
    {
        #region Properties

        #region Implementation of IEntry

        /// <inheritdoc />
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("webviewUrl")]
        public Uri WebviewUrl { get; set; }

        /// <inheritdoc />
        /// <para/>
        /// <remarks>Refers to "entryContent" property in json</remarks>
        [JsonPropertyName("entryContent")]
        public EntryLayout EntryLayout { get; set; }

        /// <inheritdoc />
        /// <para/>
        /// <remarks>Refers to "date" property in json</remarks>
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("date")]
        public DateTimeOffset DateCreated { get; set; }

        /// <inheritdoc />
        /// <para/>
        /// <remarks>Refers to "dateRFC" property in json</remarks>
        [JsonConverter(typeof(RfcDateTimeOffsetJsonConverter))]
        [JsonPropertyName("dateRFC")]
        public DateTimeOffset DateCreatedRfc { get; set; }

        /// <inheritdoc />
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("last_modification_date")]
        public DateTimeOffset LastModificationDate { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("author")]
        public User Author { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("type")]
        public ContentType Type { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("intro")]
        public string Intro { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("cover")]
        public Cover Cover { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("introInFeed")]
        public string IntroInFeed { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("similar")]
        public IEnumerable<Entry> Similar { get; set; }

        /// <inheritdoc />
        /// <para/>
        /// <remarks>Refers to "hitsCount" property in json</remarks>
        [JsonPropertyName("hitsCount")]
        public int ViewsCount { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("likes")]
        public Likes Likes { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("commentsPreview")]
        public IEnumerable<Comment> CommentsPreview { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("commentsCount")]
        public int CommentsCount { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("favoritesCount")]
        public int FavoritesCount { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("isFavorited")]
        public bool IsFavorited { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("isEnabledLikes")]
        public bool IsEnabledLikes { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("isEnabledComments")]
        public bool IsEnabledComments { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("isEditorial")]
        public bool IsEditorial { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("isPinned")]
        public bool IsPinned { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("audioUrl")]
        public Uri AudioUrl { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("badges")]
        public IEnumerable<Badge> Badges { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("commentatorsAvatars")]
        public IEnumerable<Uri> CommentatorsAvatars { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("subsite")]
        public User Subsite { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("hotness")]
        public double Hotness { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("subscribedToTreads")]
        public bool SubscribedToComments { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("blocks")]
        public IEnumerable<Block> Blocks { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("canEdit")]
        public bool CanEdit { get; set; }

        /// <inheritdoc />
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("date_favorite")]
        public DateTimeOffset DateFavorite { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("isRepost")]
        public bool IsRepost { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("is_promoted")]
        public bool IsPromoted { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("repost")]
        public Repost Repost { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("commentsSeenCount")]
        public CommentsSeenCount CommentsSeenCount { get; set; }

        /// <inheritdoc />
        /// <para/>
        /// <remarks>Refers to "etcControls" property in json</remarks>
        [JsonPropertyName("etcControls")]
        public AdditionalControls AdditionalControls { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("is_show_thanks")]
        public bool IsShowThanks { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("is_still_updating")]
        public bool IsStillUpdating { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("is_filled_by_editors")]
        public bool IsFilledByEditors { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("co_author")]
        public User CoAuthor { get; set; }

        #endregion

        #region From actual queries

        /// <summary>
        /// This entry's URL
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        /// <summary>
        /// Highlight
        /// </summary>
        [JsonPropertyName("highlight")]
        public string Highlight { get; set; }

        /// <summary>
        /// Settings for comment editor
        /// <para/>
        /// <remarks>Refers to "commentEditor" property in json</remarks>
        /// </summary>
        [JsonPropertyName("commentEditor")]
        public CommentEditorSettings CommentEditorSettings { get; set; }

        /// <summary>
        /// Summarize the entry content
        /// </summary>
        [JsonPropertyName("summarize")]
        public string Summarize { get; set; }

        [JsonPropertyName("stackedRepostsAuthors")]
        public IEnumerable<object> StackedRepostsAuthors { get; set; } // TODO: Some kind of array

        #endregion

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a default, empty entry
        /// </summary>
        public Entry() { }

        /// <summary>
        /// Creates minimal postable entry
        /// </summary>
        /// <param name="title">Title of this entry</param>
        /// <param name="blocks">Blocks inside of this entry</param>
        public Entry(string title, IEnumerable<Block> blocks) : this()
        {
            Title = title;
            Blocks = blocks;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets default entry URL
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/entry</returns>
        public static Uri GetDefaultEntryUrl(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri(baseUri, "entry");
        }

        #region GET

        #region GetEntry

        /// <summary>
        /// Gets an URL to get entry by id
        /// <para/>
        /// <remarks>Original name: getEntryById</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/entry/0</returns>
        public static Uri GetEntryUri(WebsiteKind websiteKind, int entryId, double apiVersion = Core.ApiVersion)
        {
            var relative = $"{entryId}";

            return new Uri(GetDefaultEntryUrl(websiteKind, apiVersion), relative);
        }

        /// <summary>
        /// Gets entry by id
        /// <para/>
        /// <remarks>Original name: getEntryById</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested entry</returns>
        public static ValueTask<HttpResponseMessage> GetEntryResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                           int entryId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetEntryUri(websiteKind, entryId, apiVersion));
        }

        /// <summary>
        /// Gets entry by id
        /// <para/>
        /// <remarks>Original name: getEntryById</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested entry</returns>
        public static async ValueTask<Entry> GetEntryAsync(HttpClient client, WebsiteKind websiteKind, int entryId, double apiVersion = Core.ApiVersion)
        {
            using HttpResponseMessage response = await GetEntryResponseAsync(client, websiteKind, entryId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Entry>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetPopularEntries

        // TODO: why is there entry id in params?

        /// <summary>
        /// Gets an URL to get popular entries, similar to specified id
        /// <para/>
        /// <remarks>Original name: getPopularEntries</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/entry/0/popular</returns>
        public static Uri GetPopularEntriesUri(WebsiteKind websiteKind, int entryId, double apiVersion = Core.ApiVersion)
        {
            var relative = $"{entryId}/popular";

            return new Uri(GetDefaultEntryUrl(websiteKind, apiVersion), relative);
        }

        /// <summary>
        /// Gets popular entries, similar to specified id
        /// <para/>
        /// <remarks>Original name: getPopularEntries</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested collection of entries</returns>
        public static ValueTask<HttpResponseMessage> GetPopularEntriesResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int entryId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetPopularEntriesUri(websiteKind, entryId, apiVersion));
        }

        /// <summary>
        /// Gets popular entries, similar to specified id
        /// <para/>
        /// <remarks>Original name: getPopularEntries</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested collection of entries</returns>
        public static async ValueTask<IEnumerable<Entry>> GetPopularEntriesAsync(HttpClient client, WebsiteKind websiteKind, int entryId, double apiVersion = Core.ApiVersion)
        {
            using HttpResponseMessage response = await GetPopularEntriesResponseAsync(client, websiteKind, entryId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetEntryLocate

        /// <summary>
        /// Gets an URL to get entry by it's URL
        /// <para/>
        /// <remarks>Original name: getEntryLocate</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryUri">Entry's URL</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/entry/locate?url=https://dtf.ru/0</returns>
        public static Uri GetEntryLocateUri(WebsiteKind websiteKind, Uri entryUri, double apiVersion = Core.ApiVersion)
        {
            // return new Uri(GetDefaultEntryUrl(websiteKind, apiVersion), $"{entryId}/popular");
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            // TODO: UriBuilder
            return new Uri($"{baseUri}/entry/locate?url={entryUri}");
        }

        /// <summary>
        /// Gets entry by it's URL
        /// <para/>
        /// <remarks>Original name: getEntryLocate</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryUri">Entry's URL</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested entry</returns>
        public static ValueTask<HttpResponseMessage> GetEntryLocateResponseAsync(HttpClient client, WebsiteKind websiteKind,
            Uri entryUri, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetEntryLocateUri(websiteKind, entryUri, apiVersion));
        }

        /// <summary>
        /// Gets entry by it's URL
        /// <para/>
        /// <remarks>Original name: getEntryLocate</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryUri">Entry's URL</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested entry</returns>
        public static async ValueTask<Entry> GetEntryLocateAsync(HttpClient client, WebsiteKind websiteKind, Uri entryUri, double apiVersion = Core.ApiVersion)
        {
            using HttpResponseMessage response = await GetEntryLocateResponseAsync(client, websiteKind, entryUri, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Entry>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetComments

        /// <summary>
        /// Gets an URL to get all comments
        /// <para/>
        /// <remarks>Original name: getEntryComments</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="sorting">Sorting of comments</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/entry/0/comments/date</returns>
        public static Uri GetCommentsUri(WebsiteKind websiteKind, int entryId, CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            var relative = $"{entryId}/comments/{sorting.ToString().ToLowerInvariant()}";

            return new Uri(GetDefaultEntryUrl(websiteKind, apiVersion), relative);
        }

        /// <summary>
        /// Gets comments for specified entry
        /// <para/>
        /// <remarks>Original name: getEntryComments</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="sorting">Sorting of comments</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested comments</returns>
        public static ValueTask<HttpResponseMessage> GetCommentsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int entryId, CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetCommentsUri(websiteKind, entryId, sorting, apiVersion));
        }

        /// <summary>
        /// Gets comments for specified entry
        /// <para/>
        /// <remarks>Original name: getEntryComments</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="sorting">Sorting of comments</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested comments</returns>
        public static async ValueTask<IEnumerable<Comment>> GetCommentsAsync(HttpClient client, WebsiteKind websiteKind, int entryId,
            CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            var response = await GetCommentsResponseAsync(client, websiteKind, entryId, sorting, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Comment>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetCommentsThreads

        /// <summary>
        /// Gets an URL to get comments threads
        /// <para/>
        /// <remarks>Original name: getEntryCommentsLevels</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="sorting">Sorting of comments</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/entry/0/comments/levels/date</returns>
        public static Uri GetCommentsThreadsUri(WebsiteKind websiteKind, int entryId, CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            var relative = $"{entryId}/comments/levels/{sorting.ToString().ToLowerInvariant()}";

            return new Uri(GetDefaultEntryUrl(websiteKind, apiVersion), relative);
        }

        /// <summary>
        /// Gets comments threads for specified entry
        /// <para/>
        /// <remarks>Original name: getEntryCommentsLevels</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="sorting">Sorting of comments</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested comments threads</returns>
        public static ValueTask<HttpResponseMessage> GetCommentsThreadsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int entryId, CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetCommentsThreadsUri(websiteKind, entryId, sorting, apiVersion));
        }

        /// <summary>
        /// Gets comments threads for specified entry
        /// <para/>
        /// <remarks>Original name: getEntryCommentsLevels</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="sorting">Sorting of comments</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested comments threads</returns>
        public static async ValueTask<CommentThreads> GetCommentsThreadsAsync(HttpClient client, WebsiteKind websiteKind, int entryId,
                                                                              CommentSorting sorting = CommentSorting.Date, double apiVersion = Core.ApiVersion)
        {
            var response = await GetCommentsThreadsResponseAsync(client, websiteKind, entryId, sorting, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<CommentThreads>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetCommentThread

        /// <summary>
        /// Gets an URL to get thread for specified comment
        /// <para/>
        /// <remarks>Original name: getEntryCommentsThread</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="commentId">Comment id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/entry/0/comments/thread/0</returns>
        public static Uri GetCommentThreadUri(WebsiteKind websiteKind, int entryId, int commentId, double apiVersion = Core.ApiVersion)
        {
            var relative = $"{entryId}/comments/thread/{commentId}";

            return new Uri(GetDefaultEntryUrl(websiteKind, apiVersion), relative);
        }

        /// <summary>
        /// Gets thread for specified comment
        /// <para/>
        /// <remarks>Original name: getEntryCommentsThread</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="commentId">Comment id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested thread</returns>
        public static ValueTask<HttpResponseMessage> GetCommentThreadResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int entryId, int commentId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetCommentThreadUri(websiteKind, entryId, commentId, apiVersion));
        }

        /// <summary>
        /// Gets thread for specified comment
        /// <para/>
        /// <remarks>Original name: getEntryCommentsThread</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="entryId">Entry id</param>
        /// <param name="commentId">Comment id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested thread</returns>
        public static async ValueTask<CommentThreads> GetCommentThreadAsync(HttpClient client, WebsiteKind websiteKind, int entryId,
            int commentId, double apiVersion = Core.ApiVersion)
        {
            var response = await GetCommentThreadResponseAsync(client, websiteKind, entryId, commentId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<CommentThreads>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #region POST

        #region PostEntryCreate

        /// <summary>
        /// Gets an URL to post entry
        /// <para/>
        /// <remarks>Original name: postEntryCreate</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/entry/create</returns>
        public static Uri GetEntryCreateUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            const string relative = "create";

            return new Uri(GetDefaultEntryUrl(websiteKind, apiVersion), relative);
        }

        // TODO: string entryJson overload
        // TODO: test with subsiteId = 0
        /// <summary>
        /// Posts an entry and returns it
        /// <para/>
        /// <remarks>Original name: postEntryCreate</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="subsiteId">Subsite to post</param>
        /// <param name="entry">Entry to create</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready entry</returns>
        public static async ValueTask<HttpResponseMessage> PostEntryCreateResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                                        int subsiteId, Entry entry, double apiVersion = Core.ApiVersion)
        {
            var entryJson = JsonSerializer.Serialize(entry, Core.Options); // TODO: core method?

            var titleContent = new StringContent(entry.Title);
            var idContent = new StringContent($"{subsiteId}");
            var entryContent = new StringContent(entryJson);

            var requestContent = new MultipartFormDataContent
            {
                { titleContent, "title" },
                { idContent, "subsite_id" },
                { entryContent, "entry" }
            };

            var response = await Core.PostToApiAsync(client, GetEntryCreateUri(websiteKind, apiVersion), requestContent).ConfigureAwait(false);

            Core.DisposeHttpContents(titleContent, idContent, entryContent, requestContent);

            return response;
        }

        /// <summary>
        /// Posts an entry and returns it
        /// <para/>
        /// <remarks>Original name: postEntryCreate</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="subsiteId">Subsite to post</param>
        /// <param name="entry">Entry to create</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready entry</returns>
        public static async ValueTask<Entry> PostEntryCreateAsync(HttpClient client, WebsiteKind websiteKind, int subsiteId,
                                                                  Entry entry, double apiVersion = Core.ApiVersion)
        {
            using var response = await PostEntryCreateResponseAsync(client, websiteKind, subsiteId, entry, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Entry>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }
}
