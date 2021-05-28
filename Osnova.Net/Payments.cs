using System;
using System.Net.Http;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public static class Payments
    {
        // TODO: returns 404. Just another broken piece of shit

        #region GetPaymentsCheck

        public static Uri GetPaymentsCheckUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/payments/check");
        }

        public static ValueTask<HttpResponseMessage> GetPaymentsCheckResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetPaymentsCheckUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Requires authentication!
        /// </summary>
        /// <param name="client"></param>
        /// <param name="websiteKind"></param>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public static async ValueTask<bool> GetPaymentsCheckAsync(HttpClient client, WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetPaymentsCheckResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<bool>(response).ConfigureAwait(false);
        }

        #endregion
    }
}
