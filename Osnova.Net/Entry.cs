using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Blocks;
using Osnova.Net.Enums;
using Osnova.Net.JsonConverters;

namespace Osnova.Net
{
    public class Entry
    {
        #region Properties

        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Entry's title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Link to open entry
        /// </summary>
        [JsonPropertyName("webviewUrl")]
        public Uri WebviewUrl { get; set; }

        [JsonPropertyName("entryContent")]
        public EntryLayout EntryLayout { get; set; }

        /// <summary>
        /// Entry's creation date
        /// </summary>
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Entry's creation date
        /// </summary>
        [JsonConverter(typeof(RfcDateTimeOffsetJsonConverter))]
        [JsonPropertyName("dateRFC")]
        public DateTimeOffset DateRfc { get; set; }

        /// <summary>
        /// Entry's last modification
        /// </summary>
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("last_modification_date")]
        public DateTimeOffset LastModificationDate { get; set; }

        /// <summary>
        /// Entry's author
        /// </summary>
        [JsonPropertyName("author")]
        public User Author { get; set; }

        /// <summary>
        /// Content type
        /// </summary>
        [JsonPropertyName("type")]
        public ContentType Type { get; set; }

        /// <summary>
        /// Entry's intro
        /// </summary>
        [JsonPropertyName("intro")]
        public string Intro { get; set; }

        [JsonPropertyName("cover")]
        public Cover Cover { get; set; }

        [JsonPropertyName("introInFeed")]
        public string IntroInFeed { get; set; }

        [JsonPropertyName("similar")]
        public IEnumerable<Similar> Similar { get; set; }

        /// <summary>
        /// Count of views of entry
        /// </summary>
        [JsonPropertyName("hitsCount")]
        public int ViewsCount { get; set; }

        [JsonPropertyName("likes")]
        public Likes Likes { get; set; }

        [JsonPropertyName("commentsPreview")]
        public IEnumerable<Comment> CommentsPreview { get; set; }

        [JsonPropertyName("commentsCount")]
        public int CommentsCount { get; set; }

        [JsonPropertyName("favoritesCount")]
        public int FavoritesCount { get; set; }

        [JsonPropertyName("isFavorited")]
        public bool IsFavorited { get; set; }

        [JsonPropertyName("isEnabledLikes")]
        public bool IsEnabledLikes { get; set; }

        [JsonPropertyName("isEnabledComments")]
        public bool IsEnabledComments { get; set; }

        /// <summary>
        /// Is this editoral office entry?
        /// </summary>
        [JsonPropertyName("isEditorial")]
        public bool IsEditorial { get; set; }

        /// <summary>
        /// Is this entry pinned?
        /// </summary>
        [JsonPropertyName("isPinned")]
        public bool IsPinned { get; set; }

        /// <summary>
        /// Url to voiced variant of entry
        /// </summary>
        [JsonPropertyName("audioUrl")]
        public Uri AudioUrl { get; set; }

        [JsonPropertyName("badges")]
        public IEnumerable<Badge> Badges { get; set; }

        /// <summary>
        /// Collection of commentators's avatars for preview
        /// </summary>
        [JsonPropertyName("commentatorsAvatars")]
        public IEnumerable<Uri> CommentatorsAvatars { get; set; }

        [JsonPropertyName("subsite")]
        public User Subsite { get; set; }

        [JsonPropertyName("hotness")]
        public double Hotness { get; set; }

        /// <summary>
        /// Is user subscribed to comments?
        /// </summary>
        [JsonPropertyName("subscribedToTreads")]
        public bool SubscribedToThreads { get; set; }

        /// <summary>
        /// List of blocks in entry
        /// </summary>
        [JsonPropertyName("blocks")]
        public IEnumerable<Block> Blocks { get; set; }

        /// <summary>
        /// Can user edit this post?
        /// </summary>
        [JsonPropertyName("canEdit")]
        public bool CanEdit { get; set; }

        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("date_favorite")]
        public DateTimeOffset DateFavorite { get; set; }

        [JsonPropertyName("isRepost")]
        public bool IsRepost { get; set; }

        [JsonPropertyName("is_promoted")]
        public bool IsPromoted { get; set; }

        [JsonPropertyName("repost")]
        public Repost Repost { get; set; }

        [JsonPropertyName("commentsSeenCount")]
        public CommentsSeenCount CommentsSeenCount { get; set; }

        [JsonPropertyName("etcControls")]
        public EtcControls EtcControls { get; set; }

        [JsonPropertyName("is_show_thanks")]
        public bool IsShowThanks { get; set; }

        [JsonPropertyName("is_still_updating")]
        public bool IsStillUpdating { get; set; }

        [JsonPropertyName("is_filled_by_editors")]
        public bool IsFilledByEditors { get; set; }

        [JsonPropertyName("co_author")]
        public User CoAuthor { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("highlight")]
        public string Highlight { get; set; }

        [JsonPropertyName("commentEditor")]
        public CommentEditor CommentEditor { get; set; }

        [JsonPropertyName("summarize")]
        public string Summarize { get; set; }

        [JsonPropertyName("stackedRepostsAuthors")]
        public IEnumerable<object> StackedRepostsAuthors { get; set; } // TODO: Some kind of array

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion

        #region Methods

        #region GET

        #region GetEntryById

        public static Uri GetEntryByIdUri(WebsiteKind websiteKind, int entryId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/entry/{entryId}");
        }

        public static ValueTask<HttpResponseMessage> GetEntryByIdResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int entryId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetEntryByIdUri(websiteKind, entryId, apiVersion));
        }

        public static async ValueTask<Entry> GetEntryByIdAsync(HttpClient client, WebsiteKind websiteKind, int entryId, double apiVersion = Core.ApiVersion)
        {
            using HttpResponseMessage response = await GetEntryByIdResponseAsync(client, websiteKind, entryId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Entry>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetPopularEntries

        public static Uri GetPopularEntriesUri(WebsiteKind websiteKind, int entryId, double apiVersion = Core.ApiVersion)
        {
            return new Uri($"{GetEntryByIdUri(websiteKind, entryId, apiVersion)}/popular");
        }

        public static ValueTask<HttpResponseMessage> GetPopularEntriesResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int entryId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetPopularEntriesUri(websiteKind, entryId, apiVersion));
        }

        public static async ValueTask<IEnumerable<Entry>> GetPopularEntriesAsync(HttpClient client, WebsiteKind websiteKind, int entryId, double apiVersion = Core.ApiVersion)
        {
            using HttpResponseMessage response = await GetPopularEntriesResponseAsync(client, websiteKind, entryId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetEntryLocate

        public static Uri GetEntryLocateUri(WebsiteKind websiteKind, Uri entryUri, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/entry/locate?url={entryUri}");
        }

        public static ValueTask<HttpResponseMessage> GetEntryLocateResponseAsync(HttpClient client, WebsiteKind websiteKind,
            Uri entryUri, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetEntryLocateUri(websiteKind, entryUri, apiVersion));
        }

        public static async ValueTask<Entry> GetEntryLocateAsync(HttpClient client, WebsiteKind websiteKind, Uri entryUri, double apiVersion = Core.ApiVersion)
        {
            using HttpResponseMessage response = await GetEntryLocateResponseAsync(client, websiteKind, entryUri, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Entry>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #region POST

        #region PostEntryCreate

        public static Uri GetEntryCreateUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/entry/create");
        }

        // TODO: string entryJson overload
        public static async ValueTask<HttpResponseMessage> PostEntryCreateResponseAsync(HttpClient client, WebsiteKind websiteKind,
            long subsiteId, Entry entry, double apiVersion = Core.ApiVersion)
        {
            var entryJson = JsonSerializer.Serialize(entry, Core.Options); // TODO: core method

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

        public static async ValueTask<Entry> PostEntryCreateAsync(HttpClient client, WebsiteKind websiteKind, long subsiteId,
                                                                  Entry entry, double apiVersion = Core.ApiVersion)
        {
            using var response = await PostEntryCreateResponseAsync(client, websiteKind, subsiteId, entry, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Entry>(response);
        }

        #endregion

        #endregion

        #endregion
    }
}
