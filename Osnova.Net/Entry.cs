using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Blocks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Entry
    {
        #region Properties

        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Заголовок статьи
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Ссылка, которую нужно открыть вместо открытия статьи
        /// </summary>
        [JsonPropertyName("webviewUrl")]
        public Uri WebviewUrl { get; set; }

        [JsonPropertyName("entryContent")]
        public EntryContent EntryContent { get; set; }

        /// <summary>
        /// Дата создания статьи
        /// </summary>
        [JsonPropertyName("date")]
        public long Date { get; set; }

        /// <summary>
        /// Дата создания статьи
        /// </summary>
        [JsonPropertyName("dateRFC")]
        public string DateRfc { get; set; }

        /// <summary>
        /// Дата последнего изменения статьи
        /// </summary>
        [JsonPropertyName("last_modification_date")]
        public long LastModificationDate { get; set; }

        [JsonPropertyName("author")]
        public User Author { get; set; }

        /// <summary>
        /// Тип контента:
        /// Entry = 1
        /// Vacancy = 2
        /// StaticPage = 3
        /// Event = 4
        /// Repost = 5
        /// </summary>
        [JsonPropertyName("type")]
        public ContentType Type { get; set; }

        /// <summary>
        /// Подзаголовок статьи
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
        /// Число просмотров
        /// </summary>
        [JsonPropertyName("hitsCount")]
        public long HitsCount { get; set; }

        [JsonPropertyName("likes")]
        public Likes Likes { get; set; }

        /// <summary>
        /// Список аватарок комментирующих для заглушки
        /// </summary>
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
        /// Показывает, что это пост редакции
        /// </summary>
        [JsonPropertyName("isEditorial")]
        public bool IsEditorial { get; set; }

        /// <summary>
        /// Показывает, закреплен ли пост
        /// </summary>
        [JsonPropertyName("isPinned")]
        public bool IsPinned { get; set; }

        /// <summary>
        /// Ссылка на mp3 файл с озвучкой статьи
        /// </summary>
        [JsonPropertyName("audioUrl")]
        public Uri AudioUrl { get; set; }

        [JsonPropertyName("badges")]
        public IEnumerable<Badge> Badges { get; set; }

        [JsonPropertyName("commentatorsAvatars")]
        public IEnumerable<Uri> CommentatorsAvatars { get; set; }

        [JsonPropertyName("subsite")]
        public User Subsite { get; set; }

        /// <summary>
        /// Значение хотнесса
        /// </summary>
        [JsonPropertyName("hotness")]
        public double Hotness { get; set; }

        /// <summary>
        /// Показывает, подписан ли пользователь на новые комментарии
        /// </summary>
        [JsonPropertyName("subscribedToTreads")]
        public bool SubscribedToTreads { get; set; }

        /// <summary>
        /// Список блоков для нативной статьи. Для каждого типа блока формат объекта data разный
        /// </summary>
        [JsonPropertyName("blocks")]
        public IEnumerable<Block> Blocks { get; set; }

        /// <summary>
        /// Показывает, может ли пользователь редактировать материал
        /// </summary>
        [JsonPropertyName("canEdit")]
        public bool CanEdit { get; set; }

        [JsonPropertyName("date_favorite")]
        public long? DateFavorite { get; set; }

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

        #endregion

        #region Methods

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
    }
}
