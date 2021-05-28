using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Blocks;
using Osnova.Net.Comments;
using Osnova.Net.Entries;
using Osnova.Net.Enums;
using Osnova.Net.JsonConverters;
using Osnova.Net.Notifications;
using Osnova.Net.Vacancies;

namespace Osnova.Net.Users
{
    /// <summary>
    /// Also known as Author, Subsite
    /// </summary>
    public class User : ISubsite
    {
        #region Properties

        #region IUser implementation

        /// <inheritdoc/>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <inheritdoc/>
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("created")]
        public DateTimeOffset DateCreated { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("avatar_url")]
        public Uri AvatarUrl { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("karma")]
        public int Karma { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("social_accounts")]
        public IEnumerable<SocialAccount> SocialAccounts { get; set; }

        #endregion

        #region ISubsite implementation

        /// <inheritdoc/>
        [JsonPropertyName("type")]
        public int Type { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("cover")]
        public ImageBlock ProfileCover { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("is_subscribed")]
        public bool IsSubscribed { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("is_verified")]
        public bool IsVerified { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("is_unsubscribable")]
        public bool IsUnsubscribable { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("subscribers_count")]
        public int SubscribersCount { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("comments_count")]
        public int CommentsCount { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("entries_count")]
        public int EntriesCount { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("vacancies_count")]
        public int VacanciesCount { get; set; }

        /// <inheritdoc/>
        [JsonConverter(typeof(RfcDateTimeOffsetJsonConverter))]
        [JsonPropertyName("createdRFC")]
        public DateTimeOffset DateCreatedRfc { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("push_topic")]
        public string PushTopic { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("advanced_access")]
        public AdvancedAccess AdvancedAccess { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("counters")]
        public UserCounters Counters { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("user_hash")]
        public string UserHash { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("contacts")]
        public UserContacts Contacts { get; set; }

        #endregion

        #region From actual user queries

        /// <summary>
        /// Profile's avatar
        /// </summary>
        [JsonPropertyName("avatar")]
        public ImageBlock Avatar { get; set; }

        /// <summary>
        /// Is online?
        /// </summary>
        [JsonPropertyName("is_online")]
        public bool IsOnline { get; set; }

        /// <summary>
        /// isVerified analogue of is_verified
        /// </summary>
        [Obsolete("Use IsVerified property")]
        [JsonPropertyName("isVerified")]
        public bool IsVerified2 { get; set; }

        /// <summary>
        /// Online status text
        /// </summary>
        [JsonPropertyName("online_status_text")]
        public string OnlineStatusText { get; set; }

        #endregion

        #region From actual subsite queries

        /// <summary>
        /// Is available for messenger?
        /// </summary>
        [JsonPropertyName("isAvailableForMessenger")]
        public bool IsAvailableForMessenger { get; set; }

        /// <summary>
        /// Is muted?
        /// </summary>
        [JsonPropertyName("is_muted")]
        public bool IsMuted { get; set; }

        /// <summary>
        /// isMuted analogue of is_muted
        /// </summary>
        [Obsolete("Use IsMuted")]
        [JsonPropertyName("isMuted")]
        public bool IsMuted2 { get; set; }

        /// <summary>
        /// Is subscribed to new posts?
        /// </summary>
        [JsonPropertyName("is_subscribed_to_new_posts")]
        public bool IsSubscribedToNewPosts { get; set; }

        /// <summary>
        /// Collection of subscribers avatars
        /// </summary>
        [JsonPropertyName("subscribers_avatars")]
        public IEnumerable<AvatarInfo> SubscribersAvatars { get; set; }

        /// <summary>
        /// Is plus?
        /// </summary>
        [JsonPropertyName("is_plus")]
        public bool IsPlus { get; set; }

        [JsonPropertyName("head_cover")]
        public Uri HeadCover { get; set; }

        /// <summary>
        /// Is enable writing?
        /// </summary>
        [JsonPropertyName("is_enable_writing")]
        public bool IsEnableWriting { get; set; }

        /// <summary>
        /// Subsite rules
        /// </summary>
        [JsonPropertyName("rules")]
        public string Rules { get; set; }

        /// <summary>
        /// Count of subsite events
        /// </summary>
        [JsonPropertyName("events_count")]
        public int EventsCount { get; set; }

        /// <summary>
        /// Comment editor's settigs
        /// </summary>
        [JsonPropertyName("commentEditor")]
        public CommentEditorSettings CommentEditor { get; set; }

        [JsonPropertyName("m_hash")]
        public string MHash { get; set; }

        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("m_hash_expiration_time")]
        public DateTimeOffset MHashExpirationTime { get; set; }

        /// <summary>
        /// Thanks ochoba: string and int in one list...
        /// </summary>
        [JsonPropertyName("user_hashes")]
        public IEnumerable<object> UserHashes { get; set; }

        [JsonPropertyName("highlight")]
        public string Highlight { get; set; }

        /// <summary>
        /// Can change avatar?
        /// </summary>
        [JsonPropertyName("can_change_avatar")]
        public bool CanChangeAvatar { get; set; }

        /// <summary>
        /// Can change cover?
        /// </summary>
        [JsonPropertyName("can_change_cover")]
        public bool CanChangeCover { get; set; }

        /// <summary>
        /// Is banned?
        /// </summary>
        [JsonPropertyName("is_banned")]
        public bool IsBanned { get; set; }

        [JsonConverter(typeof(WrongEmptyArrayJsonConverter<BanInfo>))]
        [JsonPropertyName("banned_info")]
        public BanInfo BanInfo { get; set; }

        [JsonPropertyName("is_subsites_tuned")]
        public bool IsSubsitesTuned { get; set; }

        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("active_until")]
        public DateTimeOffset ActiveUntil { get; set; }

        #endregion

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion

        #region Methods

        #region Get

        #region GetUser

        public static Uri GetUserUri(WebsiteKind websiteKind, int userId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/user/{userId}");
        }

        public static ValueTask<HttpResponseMessage> GetUserResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int userId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserUri(websiteKind, userId, apiVersion));
        }

        public static async ValueTask<User> GetUserAsync(HttpClient client, WebsiteKind websiteKind, int userId, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetUserResponseAsync(client, websiteKind, userId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<User>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserMe

        public static Uri GetUserMeUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/user/me");
        }

        public static ValueTask<HttpResponseMessage> GetUserMeResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserMeUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Warning: requires client to be authenticated
        /// </summary>
        /// <param name="client"></param>
        /// <param name="websiteKind"></param>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public static async ValueTask<User> GetUserMeAsync(HttpClient client, WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetUserMeResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<User>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserMeUpdates

        public static Uri GetUserMeUpdatesUri(WebsiteKind websiteKind, bool isRead = true, long lastId = -1,
                                              double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/user/me/updates");

            string isReadQuery = $"is_read={Convert.ToInt32(isRead)}";
            string lastIdQuery = lastId > -1 ? $"last_id={lastId}" : null;

            Core.BuildUri(ref builder, isReadQuery, lastIdQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetUserMeUpdatesResponseAsync(HttpClient client, WebsiteKind websiteKind,
            bool isRead = true, long lastId = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserMeUpdatesUri(websiteKind, isRead,
                                                                            lastId, apiVersion));
        }

        /// <summary>
        /// Warning: requires authentication!
        /// </summary>
        /// <returns></returns>
        public static async ValueTask<IEnumerable<Notification>> GetUserMeUpdatesAsync(HttpClient client, WebsiteKind websiteKind,
            bool isRead = true, long lastId = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserMeUpdatesResponseAsync(client, websiteKind, isRead, lastId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Notification>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserMeUpdatesCount

        public static Uri GetUserMeUpdatesCountUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/user/me/updates/count");
        }

        public static ValueTask<HttpResponseMessage> GetUserMeUpdatesCountResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserMeUpdatesCountUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Warning: requires authentication!
        /// </summary>
        /// <returns></returns>
        public static async ValueTask<Counter> GetUserMeUpdatesCountAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserMeUpdatesCountResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Counter>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserComments

        public static Uri GetUserCommentsUri(WebsiteKind websiteKind, int userId, int count = -1,
                                             int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/user/{userId}/comments");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetUserCommentsResponseAsync(HttpClient client, WebsiteKind websiteKind, int userId,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserCommentsUri(websiteKind, userId, count, offset, apiVersion));
        }

        public static async ValueTask<IEnumerable<Comment>> GetUserCommentsAsync(HttpClient client, WebsiteKind websiteKind, int userId,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserCommentsResponseAsync(client, websiteKind, userId, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Comment>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserMeComments

        public static Uri GetUserMeCommentsUri(WebsiteKind websiteKind, int count = -1,
                                             int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/user/me/comments");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetUserMeCommentsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserMeCommentsUri(websiteKind, count, offset, apiVersion));
        }

        public static async ValueTask<IEnumerable<Comment>> GetUserMeCommentsAsync(HttpClient client, WebsiteKind websiteKind,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserMeCommentsResponseAsync(client, websiteKind, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Comment>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserEntries

        public static Uri GetUserEntriesUri(WebsiteKind websiteKind, int userId, int count = -1,
                                             int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/user/{userId}/entries");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetUserEntriesResponseAsync(HttpClient client, WebsiteKind websiteKind, int userId,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserEntriesUri(websiteKind, userId, count, offset, apiVersion));
        }

        public static async ValueTask<IEnumerable<Entry>> GetUserEntriesAsync(HttpClient client, WebsiteKind websiteKind, int userId,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserEntriesResponseAsync(client, websiteKind, userId, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserMeEntries

        public static Uri GetUserMeEntriesUri(WebsiteKind websiteKind, int count = -1,
                                            int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/user/me/entries");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetUserMeEntriesResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserMeEntriesUri(websiteKind, count, offset, apiVersion));
        }

        public static async ValueTask<IEnumerable<Entry>> GetUserMeEntriesAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserMeEntriesResponseAsync(client, websiteKind, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserFavoritesEntries

        public static Uri GetUserFavoritesEntriesUri(WebsiteKind websiteKind, int userId, int count = -1,
                                            int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/user/{userId}/favorites/entries");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetUserFavoritesEntriesResponseAsync(HttpClient client, WebsiteKind websiteKind, int userId,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserFavoritesEntriesUri(websiteKind, userId, count, offset, apiVersion));
        }

        /// <summary>
        /// Requires authentication
        /// </summary>
        /// <param name="client"></param>
        /// <param name="websiteKind"></param>
        /// <param name="userId"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public static async ValueTask<IEnumerable<Entry>> GetUserFavoritesEntriesAsync(HttpClient client, WebsiteKind websiteKind, int userId,
                                                                              int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserFavoritesEntriesResponseAsync(client, websiteKind, userId, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserFavoritesComments

        public static Uri GetUserFavoritesCommentsUri(WebsiteKind websiteKind, int userId, int count = -1,
                                                      int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/user/{userId}/favorites/comments");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetUserFavoritesCommentsResponseAsync(HttpClient client, WebsiteKind websiteKind, int userId,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserFavoritesCommentsUri(websiteKind, userId, count, offset, apiVersion));
        }

        /// <summary>
        /// Requires authentication
        /// </summary>
        /// <param name="client"></param>
        /// <param name="websiteKind"></param>
        /// <param name="userId"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public static async ValueTask<IEnumerable<Comment>> GetUserFavoritesCommentsAsync(HttpClient client, WebsiteKind websiteKind, int userId,
                                                                              int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserFavoritesCommentsResponseAsync(client, websiteKind, userId, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Comment>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserFavoritesVacancies

        public static Uri GetUserFavoritesVacanciesUri(WebsiteKind websiteKind, int userId, int count = -1,
                                                       int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/user/{userId}/favorites/vacancies");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetUserFavoritesVacanciesResponseAsync(HttpClient client, WebsiteKind websiteKind, int userId,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserFavoritesVacanciesUri(websiteKind, userId, count, offset, apiVersion));
        }

        /// <summary>
        /// Requires authentication
        /// </summary>
        /// <param name="client"></param>
        /// <param name="websiteKind"></param>
        /// <param name="userId"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public static async ValueTask<IEnumerable<Vacancy>> GetUserFavoritesVacanciesAsync(HttpClient client, WebsiteKind websiteKind, int userId,
                                                                              int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserFavoritesVacanciesResponseAsync(client, websiteKind, userId, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Vacancy>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserMeFavoritesEntries

        public static Uri GetUserMeFavoritesEntriesUri(WebsiteKind websiteKind, int count = -1,
                                                       int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/user/me/favorites/entries");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetUserMeFavoritesEntriesResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserMeFavoritesEntriesUri(websiteKind, count, offset, apiVersion));
        }

        /// <summary>
        /// Requires authentication
        /// </summary>
        /// <param name="client"></param>
        /// <param name="websiteKind"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public static async ValueTask<IEnumerable<Entry>> GetUserMeFavoritesEntriesAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserMeFavoritesEntriesResponseAsync(client, websiteKind, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserMeFavoritesComments

        public static Uri GetUserMeFavoritesCommentsUri(WebsiteKind websiteKind, int count = -1,
                                                      int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/user/me/favorites/comments");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetUserMeFavoritesCommentsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserMeFavoritesCommentsUri(websiteKind, count, offset, apiVersion));
        }

        /// <summary>
        /// Requires authentication
        /// </summary>
        /// <param name="client"></param>
        /// <param name="websiteKind"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public static async ValueTask<IEnumerable<Comment>> GetUserMeFavoritesCommentsAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserMeFavoritesCommentsResponseAsync(client, websiteKind, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Comment>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserMeFavoritesVacancies

        public static Uri GetUserMeFavoritesVacanciesUri(WebsiteKind websiteKind, int count = -1,
                                                       int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/user/me/favorites/vacancies");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetUserMeFavoritesVacanciesResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserMeFavoritesVacanciesUri(websiteKind, count, offset, apiVersion));
        }

        /// <summary>
        /// Requires authentication
        /// </summary>
        /// <param name="client"></param>
        /// <param name="websiteKind"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public static async ValueTask<IEnumerable<Vacancy>> GetUserMeFavoritesVacanciesAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserMeFavoritesVacanciesResponseAsync(client, websiteKind, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Vacancy>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserMeSubscriptionsRecommended

        public static Uri GetUserMeSubscriptionsRecommendedUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/user/me/subscriptions/recommended");
        }

        public static ValueTask<HttpResponseMessage> GetUserMeSubscriptionsRecommendedResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserMeSubscriptionsRecommendedUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Requires authentication
        /// </summary>
        /// <param name="client"></param>
        /// <param name="websiteKind"></param>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public static async ValueTask<IEnumerable<User>> GetUserMeSubscriptionsRecommendedAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserMeSubscriptionsRecommendedResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<User>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserMeSubscriptionsSubscribed

        public static Uri GetUserMeSubscriptionsSubscribedUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/user/me/subscriptions/subscribed");
        }

        public static ValueTask<HttpResponseMessage> GetUserMeSubscriptionsSubscribedResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserMeSubscriptionsSubscribedUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Requires authentication
        /// </summary>
        /// <param name="client"></param>
        /// <param name="websiteKind"></param>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public static async ValueTask<IEnumerable<User>> GetUserMeSubscriptionsSubscribedAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserMeSubscriptionsSubscribedResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<User>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserMeTuneCatalog

        public static Uri GetUserMeTuneCatalogUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/user/me/tunecatalog");
        }

        public static ValueTask<HttpResponseMessage> GetUserMeTuneCatalogResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserMeTuneCatalogUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Requires authentication
        /// </summary>
        /// <param name="client"></param>
        /// <param name="websiteKind"></param>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public static async ValueTask<IEnumerable<User>> GetUserMeTuneCatalogAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserMeTuneCatalogResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<User>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetIgnoredKeywords

        public static Uri GetIgnoredKeywordsUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/subsite/get-ignored-keywords");
        }

        public static ValueTask<HttpResponseMessage> GetIgnoredKeywordsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetIgnoredKeywordsUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Requires authentication
        /// </summary>
        /// <param name="client"></param>
        /// <param name="websiteKind"></param>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public static async ValueTask<KeywordsContainer> GetIgnoredKeywordsAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            var response = await GetIgnoredKeywordsResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<KeywordsContainer>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }
}
