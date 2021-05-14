using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Event : Vacancy
    {
        #region Properties

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("date")]
        public long Date { get; set; }

        #endregion

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

        #region GetEvents

        public static Uri GetEventsUri(WebsiteKind websiteKind, int cityId = -1, IEnumerable<int> specializationIds = null, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/events");

            string specIds = null;

            if (specializationIds != null)
            {
                foreach (int id in specializationIds)
                {
                    if (string.IsNullOrWhiteSpace(specIds))
                        specIds = $"{id}";
                    else
                        specIds += $",{id}";
                }
            }

            string cityString = cityId > -1 ? $"city_id={cityId}" : null;
            string specializationsString = string.IsNullOrWhiteSpace(specIds) ? null : $"specialization_ids={specIds}";

            Core.BuildUri(ref builder, cityString, specializationsString);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetEventsResponseAsync(HttpClient client, WebsiteKind websiteKind, int cityId = -1,
                                                                            IEnumerable<int> specializationIds = null, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetEventsUri(websiteKind, cityId, specializationIds, apiVersion));
        }

        public static async ValueTask<IEnumerable<Event>> GetEventsAsync(HttpClient client, WebsiteKind websiteKind, int cityId = -1,
            IEnumerable<int> specializationIds = null, double apiVersion = Core.ApiVersion)
        {
            var response = await GetEventsResponseAsync(client, websiteKind, cityId, specializationIds, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<Event>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        #region GetEventsMore

        public static Uri GetEventsMoreUri(WebsiteKind websiteKind, long lastId, int cityId = -1,
                                           IEnumerable<int> specializationIds = null, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/events/more/{lastId}");

            string specIds = null;

            if (specializationIds != null)
            {
                foreach (int id in specializationIds)
                {
                    if (string.IsNullOrWhiteSpace(specIds))
                        specIds = $"{id}";
                    else
                        specIds += $",{id}";
                }
            }

            string cityString = cityId > -1 ? $"city_id={cityId}" : null;
            string specializationsString = string.IsNullOrWhiteSpace(specIds) ? null : $"specialization_ids={specIds}";

            Core.BuildUri(ref builder, cityString, specializationsString);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetEventsMoreResponseAsync(HttpClient client, WebsiteKind websiteKind, long lastId,
            int cityId = -1, IEnumerable<int> specializationIds = null, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetEventsMoreUri(websiteKind, lastId, cityId, specializationIds, apiVersion));
        }

        public static async ValueTask<IEnumerable<Event>> GetEventsMoreAsync(HttpClient client, WebsiteKind websiteKind, long lastId, int cityId = -1,
               IEnumerable<int> specializationIds = null, double apiVersion = Core.ApiVersion)
        {
            var response = await GetEventsMoreResponseAsync(client, websiteKind, lastId, cityId, specializationIds, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<Event>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        #endregion

        #endregion
    }
}
