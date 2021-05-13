using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Webhooks
    {
        #region GET

        #region GetApiWebhooksGet

        public static Uri GetApiWebhooksGetUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/webhooks/get");
        }

        public static ValueTask<HttpResponseMessage> GetApiWebhooksGetResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                               double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetApiWebhooksGetUri(websiteKind, apiVersion));
        }

        public static async ValueTask<IEnumerable<Watcher>> GetApiWebhooksGetAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              double apiVersion = Core.ApiVersion)
        {
            using var response = await GetApiWebhooksGetResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Watcher>>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #region POST

        #region PostApiWebhookAdd

        public static Uri GetApiWebhooksAddUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/webhooks/add");
        }

        public static async ValueTask<HttpResponseMessage> PostApiWebhooksAddResponseAsync(HttpClient client, WebsiteKind websiteKind,
            Uri url, string eventName, double apiVersion = Core.ApiVersion)
        {
            var urlContent = new StringContent(url.ToString());
            var eventContent = new StringContent(eventName);
            var requestContent = new MultipartFormDataContent
            {
                { urlContent, "\"url\"" },
                { eventContent, "\"event\"" }
            };

            var response = await Core.PostToApiAsync(client, GetApiWebhooksAddUri(websiteKind, apiVersion), requestContent).ConfigureAwait(false);

            Core.DisposeHttpContents(urlContent, eventContent, requestContent);

            return response;
        }

        public static async ValueTask<Watcher> PostApiWebhooksAddAsync(HttpClient client, WebsiteKind websiteKind,
            Uri url, string eventName, double apiVersion = Core.ApiVersion)
        {
            using var response = await PostApiWebhooksAddResponseAsync(client, websiteKind, url, eventName, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Watcher>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion
    }
}
