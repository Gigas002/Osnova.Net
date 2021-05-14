using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Mentions
    {
        #region Methods

        #region GET

        #region GetSearchForMentions

        public static Uri GetSearchForMentionsUri(WebsiteKind websiteKind, string query, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/search-for-mentions");

            string queryString = $"q={query}";

            Core.BuildUri(ref builder, queryString);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetSearchForMentionsResponseAsync(HttpClient client, WebsiteKind websiteKind, string query,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSearchForMentionsUri(websiteKind, query, apiVersion));
        }

        /// <summary>
        /// Requires authentication
        /// </summary>
        /// <param name="client"></param>
        /// <param name="websiteKind"></param>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public static async ValueTask<IEnumerable<MentionedUser>> GetSearchForMentionsAsync(HttpClient client, WebsiteKind websiteKind, string query,
                                                                                      double apiVersion = Core.ApiVersion)
        {
            var response = await GetSearchForMentionsResponseAsync(client, websiteKind, query, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<MentionedUser>>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }

    public class MentionedUser
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("img")]
        public Uri Image { get; set; }

        [JsonPropertyName("is_me")]
        public bool IsMe { get; set; }

        [JsonPropertyName("is_verified")]
        public bool IsVerified { get; set; }
    }
}
