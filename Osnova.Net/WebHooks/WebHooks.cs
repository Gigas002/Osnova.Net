using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net.WebHooks
{
    [Obsolete("Use WebHookWatcher")]
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

        public static async ValueTask<IEnumerable<WebhookWatcher>> GetApiWebhooksGetAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              double apiVersion = Core.ApiVersion)
        {
            using var response = await GetApiWebhooksGetResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<WebhookWatcher>>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #region POST

        #region PostApiWebhookAdd

        public static Uri GetApiWebhookAddUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/webhooks/add");
        }

        public static async ValueTask<HttpResponseMessage> PostApiWebhookAddResponseAsync(HttpClient client, WebsiteKind websiteKind,
            Uri url, string eventName, double apiVersion = Core.ApiVersion)
        {
            var urlContent = new StringContent(url.ToString());
            var eventContent = new StringContent(eventName);
            var requestContent = new MultipartFormDataContent
            {
                { urlContent, "\"url\"" },
                { eventContent, "\"event\"" }
            };

            var response = await Core.PostToApiAsync(client, GetApiWebhookAddUri(websiteKind, apiVersion), requestContent).ConfigureAwait(false);

            Core.DisposeHttpContents(urlContent, eventContent, requestContent);

            return response;
        }

        public static async ValueTask<WebhookWatcher> PostApiWebhookAddAsync(HttpClient client, WebsiteKind websiteKind,
            Uri url, string eventName, double apiVersion = Core.ApiVersion)
        {
            using var response = await PostApiWebhookAddResponseAsync(client, websiteKind, url, eventName, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<WebhookWatcher>(response).ConfigureAwait(false);
        }

        #endregion

        #region PostApiWebhookDel

        public static Uri GetApiWebhookDelUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/webhooks/del");
        }

        public static async ValueTask<HttpResponseMessage> PostApiWebhookDelResponseAsync(HttpClient client, WebsiteKind websiteKind,
            string eventName, double apiVersion = Core.ApiVersion)
        {
            var eventContent = new StringContent(eventName);
            var requestContent = new MultipartFormDataContent
            {
                { eventContent, "\"event\"" }
            };

            var response = await Core.PostToApiAsync(client, GetApiWebhookDelUri(websiteKind, apiVersion), requestContent).ConfigureAwait(false);

            Core.DisposeHttpContents(eventContent, requestContent);

            return response;
        }

        public static async ValueTask<bool> PostApiWebhookDelAsync(HttpClient client, WebsiteKind websiteKind,
                                                                      string eventName, double apiVersion = Core.ApiVersion)
        {
            using var response = await PostApiWebhookDelResponseAsync(client, websiteKind, eventName, apiVersion).ConfigureAwait(false);

            var deserialized = await Core.DeserializeOsnovaResponseAsync<Dictionary<string, bool>>(response).ConfigureAwait(false);

            return deserialized["success"];
        }

        #endregion

        #endregion
    }
}
