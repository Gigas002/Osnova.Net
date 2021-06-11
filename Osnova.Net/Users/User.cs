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

        /// <summary>
        /// Info about ban on osnova website
        /// </summary>
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

        /// <summary>
        /// Gets default user URL
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user</returns>
        public static Uri GetDefaultUserUrl(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/user");
        }
        
        /// <summary>
        /// Gets default subsite URL
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/subsite</returns>
        public static Uri GetDefaultSubsiteUrl(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/subsite");
        }

        #region GET

        #region User namespace
        
        #region GetUser

        /// <summary>
        /// Gets an URL to get user by id
        /// <para/>
        /// <remarks>Original name: getUserById</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="userId">User id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/0</returns>
        public static Uri GetUserUri(WebsiteKind websiteKind, int userId, double apiVersion = Core.ApiVersion)
        {
            var relative = $"{userId}";

            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/{relative}");
        }

        /// <inheritdoc cref="GetUserAsync"/>
        public static ValueTask<HttpResponseMessage> GetUserResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int userId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserUri(websiteKind, userId, apiVersion));
        }

        /// <summary>
        /// Gets user by id
        /// <para/>
        /// <remarks>Original name: getUserById</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="userId">User id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested user</returns>
        public static async ValueTask<User> GetUserAsync(HttpClient client, WebsiteKind websiteKind, int userId, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetUserResponseAsync(client, websiteKind, userId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<User>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetMe

        /// <summary>
        /// Gets an URL to get current logged in user
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMe</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/me</returns>
        public static Uri GetMeUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            const string relative = "me";

            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/{relative}");
        }

        /// <inheritdoc cref="GetMeAsync"/>
        public static ValueTask<HttpResponseMessage> GetMeResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetMeUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Gets current user
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMe</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested user</returns>
        public static async ValueTask<User> GetMeAsync(HttpClient client, WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetMeResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<User>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetMyUpdates

        /// <summary>
        /// Gets an URL to get notifications
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeUpdates</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="isRead">Is read</param>
        /// <param name="lastId">Last notification id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/me/updates</returns>
        public static Uri GetMyUpdatesUri(WebsiteKind websiteKind, bool isRead = true, int lastId = -1,
                                              double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/me/updates");

            string isReadQuery = $"is_read={Convert.ToInt32(isRead)}";
            string lastIdQuery = lastId > -1 ? $"last_id={lastId}" : null;

            Core.BuildUri(ref builder, isReadQuery, lastIdQuery);

            return builder.Uri;
        }

        /// <inheritdoc cref="GetMyUpdatesAsync"/>
        public static ValueTask<HttpResponseMessage> GetMyUpdatesResponseAsync(HttpClient client, WebsiteKind websiteKind,
            bool isRead = true, int lastId = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetMyUpdatesUri(websiteKind, isRead,
                                                                            lastId, apiVersion));
        }

        /// <summary>
        /// Get current user's notifications
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeUpdates</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="isRead">Is read</param>
        /// <param name="lastId">last id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of notifications</returns>
        public static async ValueTask<IEnumerable<Notification>> GetMyUpdatesAsync(HttpClient client, WebsiteKind websiteKind,
            bool isRead = true, int lastId = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetMyUpdatesResponseAsync(client, websiteKind, isRead, lastId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Notification>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetMyUpdatesCount

        /// <summary>
        /// Gets an URL to get current user's notifications count
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeUpdatesCount</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/me/updates/count</returns>
        public static Uri GetMyUpdatesCountUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            const string relative = "me/updates/count";

            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/{relative}");
        }

        /// <inheritdoc cref="GetMyUpdatesCountAsync"/>
        public static ValueTask<HttpResponseMessage> GetMyUpdatesCountResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetMyUpdatesCountUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Gets current user's notifications count
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeUpdatesCount</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Notifications count</returns>
        public static async ValueTask<Counter> GetMyUpdatesCountAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            var response = await GetMyUpdatesCountResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            // TODO: return number
            return await Core.DeserializeOsnovaResponseAsync<Counter>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserComments

        /// <summary>
        /// Gets an URL to get user's comments
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserComments</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="userId">User id</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/0/comments</returns>
        public static Uri GetUserCommentsUri(WebsiteKind websiteKind, int userId, int count = -1,
                                             int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/{userId}/comments");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        /// <inheritdoc cref="GetUserCommentsAsync"/>
        public static ValueTask<HttpResponseMessage> GetUserCommentsResponseAsync(HttpClient client, WebsiteKind websiteKind, int userId,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserCommentsUri(websiteKind, userId, count, offset, apiVersion));
        }

        /// <summary>
        /// Gets user's comments
        /// <remarks>
        /// <para/>
        /// Original name: getUserComments</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="userId">User id</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>User's comments</returns>
        public static async ValueTask<IEnumerable<Comment>> GetUserCommentsAsync(HttpClient client, WebsiteKind websiteKind, int userId,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserCommentsResponseAsync(client, websiteKind, userId, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Comment>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetMyComments

        /// <summary>
        /// Gets an URL to get current logged user's comments
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeComments</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/me/comments</returns>
        public static Uri GetMyCommentsUri(WebsiteKind websiteKind, int count = -1,
                                             int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/me/comments");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        /// <inheritdoc cref="GetMyCommentsAsync"/>
        public static ValueTask<HttpResponseMessage> GetMyCommentsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetMyCommentsUri(websiteKind, count, offset, apiVersion));
        }

        /// <summary>
        /// Gets current user's comments
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeComments</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of comments</returns>
        public static async ValueTask<IEnumerable<Comment>> GetMyCommentsAsync(HttpClient client, WebsiteKind websiteKind,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetMyCommentsResponseAsync(client, websiteKind, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Comment>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserEntries

        /// <summary>
        /// Gets an URL to get user's entries
        /// <remarks>
        /// <para/>
        /// Original name: getUserEntries</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="userId">User id</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/0/entries</returns>
        public static Uri GetUserEntriesUri(WebsiteKind websiteKind, int userId, int count = -1,
                                             int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/{userId}/entries");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        /// <inheritdoc cref="GetUserEntriesAsync"/>
        public static ValueTask<HttpResponseMessage> GetUserEntriesResponseAsync(HttpClient client, WebsiteKind websiteKind, int userId,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserEntriesUri(websiteKind, userId, count, offset, apiVersion));
        }

        /// <summary>
        /// Gets user's entries
        /// <remarks>
        /// <para/>
        /// Original name: getUserEntries</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="userId">User id</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of entries</returns>
        public static async ValueTask<IEnumerable<Entry>> GetUserEntriesAsync(HttpClient client, WebsiteKind websiteKind, int userId,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserEntriesResponseAsync(client, websiteKind, userId, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetMyEntries

        /// <summary>
        /// Gets an URL to get current user's entries
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeEntries</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/me/entries</returns>
        public static Uri GetMyEntriesUri(WebsiteKind websiteKind, int count = -1,
                                            int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/me/entries");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        /// <inheritdoc cref="GetMyEntriesAsync"/>
        public static ValueTask<HttpResponseMessage> GetMyEntriesResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetMyEntriesUri(websiteKind, count, offset, apiVersion));
        }

        /// <summary>
        /// Gets current user's entries
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeEntries</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of entries</returns>
        public static async ValueTask<IEnumerable<Entry>> GetMyEntriesAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetMyEntriesResponseAsync(client, websiteKind, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserFavoritesEntries

        /// <summary>
        /// Gets an URL to get user's favorite entries
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserFavoritesEntries</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="userId">User id</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/0/favorites/entries</returns>
        public static Uri GetUserFavoriteEntriesUri(WebsiteKind websiteKind, int userId, int count = -1,
                                            int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/{userId}/favorites/entries");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        /// <inheritdoc cref="GetUserFavoriteEntriesAsync"/>
        public static ValueTask<HttpResponseMessage> GetUserFavoriteEntriesResponseAsync(HttpClient client, WebsiteKind websiteKind, int userId,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserFavoriteEntriesUri(websiteKind, userId, count, offset, apiVersion));
        }

        /// <summary>
        /// Gets user's favorite entries
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserFavoritesEntries</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="userId">User id</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of entries</returns>
        public static async ValueTask<IEnumerable<Entry>> GetUserFavoriteEntriesAsync(HttpClient client, WebsiteKind websiteKind, int userId,
                                                                              int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserFavoriteEntriesResponseAsync(client, websiteKind, userId, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserFavoritesComments

        /// <summary>
        /// Gets an URL to get user's favorite comments
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserFavoritesComments</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="userId">User id</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/0/favorites/comments</returns>
        public static Uri GetUserFavoriteCommentsUri(WebsiteKind websiteKind, int userId, int count = -1,
                                                      int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/{userId}/favorites/comments");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        /// <inheritdoc cref="GetUserFavoriteCommentsAsync"/>
        public static ValueTask<HttpResponseMessage> GetUserFavoriteCommentsResponseAsync(HttpClient client, WebsiteKind websiteKind, int userId,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserFavoriteCommentsUri(websiteKind, userId, count, offset, apiVersion));
        }

        /// <summary>
        /// Gets user's favorite comments
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserFavoritesComments</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="userId">User id</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of comments</returns>
        public static async ValueTask<IEnumerable<Comment>> GetUserFavoriteCommentsAsync(HttpClient client, WebsiteKind websiteKind, int userId,
                                                                              int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserFavoriteCommentsResponseAsync(client, websiteKind, userId, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Comment>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetUserFavoritesVacancies

        /// <summary>
        /// Gets an URL to get user's favorite vacancies
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserFavoritesVacancies</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="userId">User id</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/0/favorites/vacancies</returns>
        public static Uri GetUserFavoriteVacanciesUri(WebsiteKind websiteKind, int userId, int count = -1,
                                                       int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/{userId}/favorites/vacancies");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        /// <inheritdoc cref="GetUserFavoriteVacanciesAsync"/>
        public static ValueTask<HttpResponseMessage> GetUserFavoriteVacanciesResponseAsync(HttpClient client, WebsiteKind websiteKind, int userId,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserFavoriteVacanciesUri(websiteKind, userId, count, offset, apiVersion));
        }

        /// <summary>
        /// Gets user's favorite vacancies
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserFavoritesVacancies</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="userId">User id</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of vacancies</returns>
        public static async ValueTask<IEnumerable<Vacancy>> GetUserFavoriteVacanciesAsync(HttpClient client, WebsiteKind websiteKind, int userId,
                                                                              int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetUserFavoriteVacanciesResponseAsync(client, websiteKind, userId, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Vacancy>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetMyFavoriteEntries

        /// <summary>
        /// Gets an URL to get current user's favorite entries
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeFavoritesEntries</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/me/favorites/entries</returns>
        public static Uri GetMyFavoriteEntriesUri(WebsiteKind websiteKind, int count = -1,
                                                       int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/me/favorites/entries");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        /// <inheritdoc cref="GetMyFavoriteEntriesAsync"/>
        public static ValueTask<HttpResponseMessage> GetMyFavoriteEntriesResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetMyFavoriteEntriesUri(websiteKind, count, offset, apiVersion));
        }

        /// <summary>
        /// Gets current user's favorite entries
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeFavoritesEntries</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of entries</returns>
        public static async ValueTask<IEnumerable<Entry>> GetMyFavoriteEntriesAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetMyFavoriteEntriesResponseAsync(client, websiteKind, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetMyFavoriteComments

        /// <summary>
        /// Gets an URL to get current user's favorite comments
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeFavoritesComments</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/me/favorites/comments</returns>
        public static Uri GetMyFavoriteCommentsUri(WebsiteKind websiteKind, int count = -1,
                                                      int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/me/favorites/comments");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        /// <inheritdoc cref="GetMyFavoriteCommentsAsync"/>
        public static ValueTask<HttpResponseMessage> GetMyFavoriteCommentsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetMyFavoriteCommentsUri(websiteKind, count, offset, apiVersion));
        }

        /// <summary>
        /// Gets current user's favorite comments
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeFavoritesComments</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of comments</returns>
        public static async ValueTask<IEnumerable<Comment>> GetMyFavoriteCommentsAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetMyFavoriteCommentsResponseAsync(client, websiteKind, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Comment>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetMyFavoriteVacancies

        /// <summary>
        /// Gets an URL to get current user's favorite vacancies
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeFavoritesVacancies</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/me/favorites/vacancies</returns>
        public static Uri GetMyFavoriteVacanciesUri(WebsiteKind websiteKind, int count = -1,
                                                       int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/me/favorites/vacancies");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        /// <inheritdoc cref="GetMyFavoriteVacanciesAsync"/>
        public static ValueTask<HttpResponseMessage> GetMyFavoriteVacanciesResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetMyFavoriteVacanciesUri(websiteKind, count, offset, apiVersion));
        }

        /// <summary>
        /// Gets current user's favorite vacancies
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeFavoritesVacancies</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of vacancies</returns>
        public static async ValueTask<IEnumerable<Vacancy>> GetMyFavoriteVacanciesAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetMyFavoriteVacanciesResponseAsync(client, websiteKind, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Vacancy>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetMyRecommendedSubscriptions

        /// <summary>
        /// Gets an URL to get current user's recommended subscriptions
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeSubscriptionsRecommended</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/me/subscriptions/recommended</returns>
        public static Uri GetMyRecommendedSubscriptionsUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/me/subscriptions/recommended");
        }

        /// <inheritdoc cref="GetMyRecommendedSubscriptionsAsync"/>
        public static ValueTask<HttpResponseMessage> GetMyRecommendedSubscriptionsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetMyRecommendedSubscriptionsUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Gets current user's recommended subscriptions
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeSubscriptionsRecommended</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of users</returns>
        public static async ValueTask<IEnumerable<User>> GetMyRecommendedSubscriptionsAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            var response = await GetMyRecommendedSubscriptionsResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<User>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetMySubscriptionsSubscribed

        // TODO: rename to Subscriptions or Subscribed
        
        /// <summary>
        /// Gets an URL to get current user's subscriptions
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeSubscriptionsSubscribed</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/me/subscriptions/subscribed</returns>
        public static Uri GetMySubscriptionsSubscribedUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/me/subscriptions/subscribed");
        }

        /// <inheritdoc cref="GetMySubscriptionsSubscribedAsync"/>
        public static ValueTask<HttpResponseMessage> GetMySubscriptionsSubscribedResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetMySubscriptionsSubscribedUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Gets current user's subscriptions
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeSubscriptionsSubscribed</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of users</returns>
        public static async ValueTask<IEnumerable<User>> GetMySubscriptionsSubscribedAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            var response = await GetMySubscriptionsSubscribedResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<User>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetMyTuneCatalog

        /// <summary>
        /// Gets an URL to get current user's tune catalog
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeTuneCatalog</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/user/me/tunecatalog</returns>
        public static Uri GetMyTuneCatalogUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultUserUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/me/tunecatalog");
        }

        /// <inheritdoc cref="GetMyTuneCatalogAsync"/>
        public static ValueTask<HttpResponseMessage> GetMyTuneCatalogResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetMyTuneCatalogUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Gets current user's tune catalog
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getUserMeTuneCatalog</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of users</returns>
        public static async ValueTask<IEnumerable<User>> GetMyTuneCatalogAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            var response = await GetMyTuneCatalogResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<User>>(response).ConfigureAwait(false);
        }

        #endregion
        
        #endregion

        #region Subsite namespace

        #region GetIgnoredKeywords

        /// <summary>
        /// Gets an URL to get current user's ignored keywords
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getIgnoredKeywords</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/subsite/get-ignored-keywords</returns>
        public static Uri GetIgnoredKeywordsUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultSubsiteUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/get-ignored-keywords");
        }

        /// <inheritdoc cref="GetIgnoredKeywordsAsync"/>
        public static ValueTask<HttpResponseMessage> GetIgnoredKeywordsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetIgnoredKeywordsUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Gets current user's ignored keywords
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getIgnoredKeywords</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of keywords</returns>
        public static async ValueTask<KeywordsContainer> GetIgnoredKeywordsAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            var response = await GetIgnoredKeywordsResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            // TODO: return collection of strings
            return await Core.DeserializeOsnovaResponseAsync<KeywordsContainer>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetSubsite

        /// <summary>
        /// Gets an URL to get subsite by id
        /// <para/>
        /// <remarks>Original name: getSubsite</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="subsiteId">Subsite id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/subsite/0</returns>
        public static Uri GetSubsiteUri(WebsiteKind websiteKind, int subsiteId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultSubsiteUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/{subsiteId}");
        }

        /// <inheritdoc cref="GetSubsiteAsync"/>
        public static ValueTask<HttpResponseMessage> GetSubsiteResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int subsiteId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSubsiteUri(websiteKind, subsiteId, apiVersion));
        }

        /// <summary>
        /// Gets subsite by id
        /// <para/>
        /// <remarks>Original name: getSubsite</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="subsiteId">Entry id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested subsite</returns>
        public static async ValueTask<User> GetSubsiteAsync(HttpClient client, WebsiteKind websiteKind, int subsiteId, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetSubsiteResponseAsync(client, websiteKind, subsiteId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<User>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetSubsiteTimeline

        /// <summary>
        /// Gets an URL to get subsite's timeline
        /// <para/>
        /// <remarks>Original name: getSubsiteTimeline</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="subsiteId">Subsite id</param>
        /// <param name="sorting">Sorting of entries</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/subsite/0/timeline</returns>
        public static Uri GetSubsiteTimelineUri(WebsiteKind websiteKind, int subsiteId,
               SubsiteTimelineSorting sorting = SubsiteTimelineSorting.Default,
               int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultSubsiteUrl(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/{subsiteId}/timeline{Core.ConvertSubsiteTimelineSorting(sorting)}");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        /// <inheritdoc cref="GetSubsiteTimelineAsync"/>
        public static ValueTask<HttpResponseMessage> GetSubsiteTimelineResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int subsiteId, SubsiteTimelineSorting sorting = SubsiteTimelineSorting.Default,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSubsiteTimelineUri(websiteKind, subsiteId, sorting, count,
                                                                              offset, apiVersion));
        }

        /// <summary>
        /// Gets subsite's timeline (collection of entries)
        /// <para/>
        /// <remarks>Original name: getSubsiteTimeline</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="subsiteId">Subsite id</param>
        /// <param name="sorting">Sorting of entries</param>
        /// <param name="count">Count</param>
        /// <param name="offset">Offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of entries</returns>
        public static async ValueTask<IEnumerable<Entry>> GetSubsiteTimelineAsync(HttpClient client, WebsiteKind websiteKind,
            int subsiteId, SubsiteTimelineSorting sorting = SubsiteTimelineSorting.Default,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetSubsiteTimelineResponseAsync(client, websiteKind, subsiteId, sorting, count,
                                                                 offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetSubsitesList

        /// <summary>
        /// Gets an URL to get subsites list
        /// <para/>
        /// <remarks>Original name: getSubsitesList</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="subsiteType">Subsite type</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/subsites_list/sections</returns>
        public static Uri GetSubsitesListUri(WebsiteKind websiteKind, SubsiteTypes subsiteType = SubsiteTypes.Sections,
                                             double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/subsites_list/{subsiteType.ToString().ToLowerInvariant()}");
        }

        /// <inheritdoc cref="GetSubsitesListAsync"/>
        public static ValueTask<HttpResponseMessage> GetSubsitesListResponseAsync(HttpClient client, WebsiteKind websiteKind,
            SubsiteTypes subsiteType = SubsiteTypes.Sections, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSubsitesListUri(websiteKind, subsiteType, apiVersion));
        }

        /// <summary>
        /// Gets subsites list
        /// <para/>
        /// <remarks>Original name: getSubsitesList</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="subsiteType">Subsite type</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of subsites</returns>
        public static async ValueTask<IEnumerable<User>> GetSubsitesListAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              SubsiteTypes subsiteType = SubsiteTypes.Sections, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetSubsitesListResponseAsync(client, websiteKind, subsiteType, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<User>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetCompanyVacancies

        // TODO: move to Company
        
        /// <summary>
        /// Gets an URL to get company's (not user/subsite) vacancies
        /// <para/>
        /// <remarks>Original name: getSubsiteVacancies</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="companyId">Company id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/subsite/0/vacancies</returns>
        public static Uri GetCompanyVacanciesUri(WebsiteKind websiteKind, int companyId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultSubsiteUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/{companyId}/vacancies");
        }

        /// <inheritdoc cref="GetCompanyVacanciesAsync"/>
        public static ValueTask<HttpResponseMessage> GetCompanyVacanciesResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int companyId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetCompanyVacanciesUri(websiteKind, companyId, apiVersion));
        }

        /// <summary>
        /// Gets company's (not user/subsite) vacancies
        /// <para/>
        /// <remarks>Original name: getSubsiteVacancies</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="companyId">Company id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of vacancies</returns>
        public static async ValueTask<IEnumerable<Vacancy>> GetCompanyVacanciesAsync(HttpClient client, WebsiteKind websiteKind,
            int companyId, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetCompanyVacanciesResponseAsync(client, websiteKind, companyId, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<Vacancy>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        #region GetCompanyVacanciesMore

        // TODO: move to Company

        /// <summary>
        /// Gets an URL to get more company's (not user/subsite) vacancies
        /// <para/>
        /// <remarks>Original name: getSubsiteVacanciesMore</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="companyId">Company id</param>
        /// <param name="lastId">Last id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/subsite/0/vacancies/more/0</returns>
        public static Uri GetCompanyMoreVacanciesUri(WebsiteKind websiteKind, int companyId,
            int lastId = 0, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultSubsiteUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/{companyId}/vacancies/more/{lastId}");
        }

        /// <inheritdoc cref="GetCompanyMoreVacanciesAsync"/>
        public static ValueTask<HttpResponseMessage> GetCompanyMoreVacanciesResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int companyId, int lastId = 0, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetCompanyMoreVacanciesUri(websiteKind, companyId, lastId, apiVersion));
        }

        /// <summary>
        /// Gets more company's (not user/subsite) vacancies
        /// <para/>
        /// <remarks>Original name: getSubsiteVacanciesMore</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="companyId">Company id</param>
        /// <param name="lastId">Last id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of vacancies</returns>
        public static async ValueTask<IEnumerable<Vacancy>> GetCompanyMoreVacanciesAsync(HttpClient client, WebsiteKind websiteKind,
            int companyId, int lastId = 0, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetCompanyMoreVacanciesResponseAsync(client, websiteKind, companyId, lastId, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<Vacancy>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        #region GetSubsiteSubscribe

        /// <summary>
        /// Always throws 403
        /// </summary>
        [Obsolete]
        public static Uri GetSubsiteSubscribeUri(WebsiteKind websiteKind, int subsiteId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultSubsiteUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/{subsiteId}/subscribe");
        }

        /// <inheritdoc cref="GetSubsiteSubscribeUri"/>
        [Obsolete]
        public static ValueTask<HttpResponseMessage> GetSubsiteSubscribeResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int subsiteId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSubsiteSubscribeUri(websiteKind, subsiteId, apiVersion));
        }

        /// <inheritdoc cref="GetSubsiteSubscribeUri"/>
        [Obsolete]
        public static async ValueTask<bool> GetSubsiteSubscribeAsync(HttpClient client, WebsiteKind websiteKind,
            int subsiteId, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetSubsiteSubscribeResponseAsync(client, websiteKind, subsiteId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<bool>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetSubsiteUnsubscribe

        /// <inheritdoc cref="GetSubsiteSubscribeUri"/>
        [Obsolete]
        public static Uri GetSubsiteUnsubscribeUri(WebsiteKind websiteKind, int subsiteId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultSubsiteUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/{subsiteId}/unsubscribe");
        }

        /// <inheritdoc cref="GetSubsiteSubscribeUri"/>
        [Obsolete]
        public static ValueTask<HttpResponseMessage> GetSubsiteUnsubscribeResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int subsiteId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSubsiteUnsubscribeUri(websiteKind, subsiteId, apiVersion));
        }

        /// <inheritdoc cref="GetSubsiteSubscribeUri"/>
        [Obsolete]
        public static async ValueTask<bool> GetSubsiteUnsubscribeAsync(HttpClient client, WebsiteKind websiteKind,
            int subsiteId, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetSubsiteUnsubscribeResponseAsync(client, websiteKind, subsiteId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<bool>(response).ConfigureAwait(false);
        }

        #endregion
        
        #endregion
        
        #endregion

        #endregion
    }
}
