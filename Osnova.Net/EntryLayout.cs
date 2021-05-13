using System;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class EntryLayout
    {
        [JsonPropertyName("html")]
        public string Html { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        #region GetLayout

        // TODO: the same version, as API?
        public static Uri GetLayoutUri(WebsiteKind websiteKind, double version, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/layout/{version}");
        }

        public static ValueTask<HttpResponseMessage> GetLayoutResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                            double version, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetLayoutUri(websiteKind, version, apiVersion));
        }

        public static async ValueTask<EntryLayout> GetLayoutAsync(HttpClient client, WebsiteKind websiteKind, double version, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetLayoutResponseAsync(client, websiteKind, version, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<EntryLayout>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetLayoutHashtag

        public static Uri GetLayoutHashtagUri(WebsiteKind websiteKind, string hashtag, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            // TODO: original uri: /layout/hashtag/{hashtag} doesn't work at all
            return new Uri($"{baseUri}/layout/{hashtag}");
        }

        public static ValueTask<HttpResponseMessage> GetLayoutHashtagResponseAsync(HttpClient client, WebsiteKind websiteKind,
            string hashtag, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetLayoutHashtagUri(websiteKind, hashtag, apiVersion));
        }

        public static async ValueTask<EntryLayout> GetLayoutHashtagAsync(HttpClient client, WebsiteKind websiteKind, string hashtag, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetLayoutHashtagResponseAsync(client, websiteKind, hashtag, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<EntryLayout>(response).ConfigureAwait(false);
        }

        #endregion
    }
}
