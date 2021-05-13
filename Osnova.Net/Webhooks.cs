using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Webhooks
    {
        // TODO: needs more tests

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
    }
}
