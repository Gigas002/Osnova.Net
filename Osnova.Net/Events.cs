using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Events
    {
        #region Methods

        #region GET

        #region GetEventsFilters

        public static Uri GetEventsFiltersUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/events/filters");
        }

        public static ValueTask<HttpResponseMessage> GetEventsFiltersResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetEventsFiltersUri(websiteKind, apiVersion));
        }

        public static async ValueTask<JobOrEventFilters> GetEventsFiltersAsync(HttpClient client, WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetEventsFiltersResponseAsync(client, websiteKind,apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<JobOrEventFilters>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }
}
