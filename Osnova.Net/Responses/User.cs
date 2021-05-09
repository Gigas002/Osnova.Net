using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Responses.Blocks;

namespace Osnova.Net.Responses
{
    public class User
    {
        #region Properties

        #region From getUser docs

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("type")]
        public long Type { get; set; } // TODO: some kind of enum?

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Аватарка профиля
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public Uri AvatarUrl { get; set; }

        /// <summary>
        /// Обложка профиля
        /// </summary>
        [JsonPropertyName("cover")]
        public Block Cover { get; set; } // TODO: wrong info in spec? see getUserById

        [JsonPropertyName("is_subscribed")]
        public bool IsSubscribed { get; set; }

        [JsonPropertyName("is_verified")]
        public bool IsVerified { get; set; }

        [JsonPropertyName("is_unsubscribable")]
        public bool IsUnsubscribable { get; set; }

        [JsonPropertyName("subscribers_count")]
        public int SubscribersCount { get; set; }

        [JsonPropertyName("comments_count")]
        public int CommentsCount { get; set; }

        [JsonPropertyName("entries_count")]
        public int EntriesCount { get; set; }

        [JsonPropertyName("vacancies_count")]
        public int VacanciesCount { get; set; }

        [JsonPropertyName("created")]
        public long Created { get; set; }

        [JsonPropertyName("createdRFC")]
        public string CreatedRFC { get; set; }

        [JsonPropertyName("karma")]
        public long Karma { get; set; }

        /// <summary>
        /// Список прикрепленных аккаунтов
        /// </summary>
        [JsonPropertyName("social_accounts")]
        public IEnumerable<SocialAccount> SocialAccounts { get; set; }

        /// <summary>
        /// Личный топик пользователя в Firebase Messaging
        /// </summary>
        [JsonPropertyName("push_topic")]
        public string PushTopic { get; set; }

        /// <summary>
        /// Список разрешений
        /// </summary>
        [JsonPropertyName("advanced_access")]
        public AdvancedAccess AdvancedAccess { get; set; }

        [JsonPropertyName("counters")]
        public Counters Counters { get; set; }

        /// <summary>
        /// Хеш ID пользователя. Используется для сравнения данных, где ID захеширован
        /// </summary>
        [JsonPropertyName("user_hash")]
        public string UserHash { get; set; }

        [JsonPropertyName("contacts")]
        public Contacts Contacts { get; set; }

        #endregion

        #region Additional from actual query

        [JsonPropertyName("avatar")]
        public Block Avatar { get; set; }

        [JsonPropertyName("is_online")]
        public bool IsOnline { get; set; }

        [JsonPropertyName("isAvailableForMessenger")]
        public bool IsAvailableForMessenger { get; set; }

        [JsonPropertyName("isMuted")]
        public bool IsMuted { get; set; }

        [JsonPropertyName("is_subscribed_to_new_posts")]
        public bool IsSubscribedToNewPosts { get; set; }

        [JsonPropertyName("subscribers_avatars")]
        public IEnumerable<SubscriberAvatar> SubscribersAvatars { get; set; }

        [JsonPropertyName("is_plus")]
        public bool IsPlus { get; set; }

        #endregion

        #region Specific from getEntryById

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        #endregion

        #endregion

        #region Methods

        #region GetUser

        public static Uri GetUserUri(WebsiteKind websiteKind, int userId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/user/{userId}");
        }

        public static async ValueTask<HttpResponseMessage> GetUserResponseAsync(HttpClient client, WebsiteKind websiteKind,
            int userId, double apiVersion = Core.ApiVersion)
        {
            var response = await client.GetAsync(GetUserUri(websiteKind, userId, apiVersion)).ConfigureAwait(false);

            var isOk = Core.CheckResponse(response, HttpStatusCode.OK);

            return isOk ? response : null;
        }

        public static async ValueTask<User> GetUser(HttpClient client, WebsiteKind websiteKind, int userId, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetUserResponseAsync(client, websiteKind, userId, apiVersion).ConfigureAwait(false);

            await using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);

            var osnovaResponse = await JsonSerializer.DeserializeAsync<OsnovaResponse<User>>(stream).ConfigureAwait(false);

            return osnovaResponse?.Result;
        }

        #endregion

        #endregion
    }
}
