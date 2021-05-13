using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Hashtag
    {
        #region Properties

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("content_count")]
        public int ContentCount { get; set; }

        #endregion

        #region Methods

        #region GET

        #region GetIgnoresHashtags

        public static Uri GetIgnoresHashtagsUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/ignores/hashtags");
        }

        public static ValueTask<HttpResponseMessage> GetIgnoresHashtagsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetIgnoresHashtagsUri(websiteKind, apiVersion));
        }

        public static async ValueTask<IEnumerable<Hashtag>> GetIgnoresHashtagsAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            using var response = await GetIgnoresHashtagsResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Hashtag>>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }
}
