using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Companies;
using Osnova.Net.Enums;
using Osnova.Net.Filters;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.OsnovaEvents
{
    /// <summary>
    /// Also known as Event
    /// </summary>
    public class OsnovaEvent : IOsnovaEvent
    {
        #region Properties

        #region IOsnoveEvent implementation

        /// <inheritdoc />
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("archived")]
        public bool IsArchived { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("entry_id")]
        public int EntryId { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("city_id")]
        public int CityId { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <inheritdoc />
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
        [JsonPropertyName("price")]
        public int Price { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("favoritesCount")]
        public int FavoritesCount { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("isFavorited")]
        public bool IsFavorited { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("company")]
        public Company Company { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("interested")]
        public int Interested { get; set; }

        #endregion

        #region From actual queries

        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }

        #endregion

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

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

        public static async ValueTask<EventFilters> GetEventsFiltersAsync(HttpClient client, WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetEventsFiltersResponseAsync(client, websiteKind,apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<EventFilters>(response).ConfigureAwait(false);
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

        public static async ValueTask<IEnumerable<OsnovaEvent>> GetEventsAsync(HttpClient client, WebsiteKind websiteKind, int cityId = -1,
            IEnumerable<int> specializationIds = null, double apiVersion = Core.ApiVersion)
        {
            var response = await GetEventsResponseAsync(client, websiteKind, cityId, specializationIds, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<OsnovaEvent>>(response).ConfigureAwait(false);

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

        public static async ValueTask<IEnumerable<OsnovaEvent>> GetEventsMoreAsync(HttpClient client, WebsiteKind websiteKind, long lastId, int cityId = -1,
               IEnumerable<int> specializationIds = null, double apiVersion = Core.ApiVersion)
        {
            var response = await GetEventsMoreResponseAsync(client, websiteKind, lastId, cityId, specializationIds, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<OsnovaEvent>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        // TODO: add https://api.vc.ru/v1.9/events/widget, not in the docs, returns array of events

        #endregion

        #endregion
    }
}
