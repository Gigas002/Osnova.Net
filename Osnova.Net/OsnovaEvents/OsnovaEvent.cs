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

        /// <summary>
        /// Event's date
        /// </summary>
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }

        #endregion

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion

        #region Methods
        
        /// <summary>
        /// Gets default events URL
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/events</returns>
        public static Uri GetDefaultEventsUrl(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/events");
        }
        
        // TODO: use use enums for city id/spec id if possible

        #region GET

        #region GetEventsFilters

        /// <summary>
        /// Gets an URL to get event filters
        /// <para/>
        /// <remarks>Original name: getEventsFilters</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/events/filters</returns>
        public static Uri GetEventsFiltersUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            const string relative = "filters";

            var baseUri = GetDefaultEventsUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/{relative}");
        }

        /// <inheritdoc cref="GetEventsFiltersAsync"/>
        public static ValueTask<HttpResponseMessage> GetEventsFiltersResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetEventsFiltersUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Gets events filters
        /// <para/>
        /// <remarks>Original name: getEventsFilters</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested events filters</returns>
        public static async ValueTask<Dictionary<string, IEnumerable<VacancyEventFilter>>> GetEventsFiltersAsync(HttpClient client, WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetEventsFiltersResponseAsync(client, websiteKind,apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Dictionary<string, IEnumerable<VacancyEventFilter>>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetEvents

        /// <summary>
        /// Gets an URL to get events
        /// <para/>
        /// <remarks>Original name: getEvents</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="cityId">City ID</param>
        /// <param name="specializationIds">Specialization ID's collection</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.vc.ru/v1.9/events?city_id=0</returns>
        public static Uri GetEventsUri(WebsiteKind websiteKind, int cityId = -1, IEnumerable<int> specializationIds = null,
            double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultEventsUrl(websiteKind, apiVersion);

            UriBuilder builder = new UriBuilder(baseUri);

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

        /// <inheritdoc cref="GetEventsAsync"/>
        public static ValueTask<HttpResponseMessage> GetEventsResponseAsync(HttpClient client, WebsiteKind websiteKind, int cityId = -1,
                                                                            IEnumerable<int> specializationIds = null, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetEventsUri(websiteKind, cityId, specializationIds, apiVersion));
        }

        /// <summary>
        /// Gets events
        /// <para/>
        /// <remarks>Original name: getEvents</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="cityId">City ID</param>
        /// <param name="specializationIds">Specialization ID's collection</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested events</returns>
        public static async ValueTask<IEnumerable<OsnovaEvent>> GetEventsAsync(HttpClient client, WebsiteKind websiteKind, int cityId = -1,
            IEnumerable<int> specializationIds = null, double apiVersion = Core.ApiVersion)
        {
            var response = await GetEventsResponseAsync(client, websiteKind, cityId, specializationIds, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<OsnovaEvent>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        #region GetMoreEvents

        /// <summary>
        /// Gets an URL to get more events
        /// <para/>
        /// <remarks>Original name: getEventsMore</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="lastId">Last event's ID of previous query</param>
        /// <param name="cityId">City ID</param>
        /// <param name="specializationIds">Specialization ID's collection</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.vc.ru/v1.9/events/more/0?city_id=0</returns>
        public static Uri GetMoreEventsUri(WebsiteKind websiteKind, int lastId = 0, int cityId = -1,
                                           IEnumerable<int> specializationIds = null, double apiVersion = Core.ApiVersion)
        {
            string relative = $"more/{lastId}";

            var baseUri = GetDefaultEventsUrl(websiteKind, apiVersion);
            
            UriBuilder builder = new($"{baseUri}/{relative}");

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

        /// <inheritdoc cref="GetMoreEventsAsync"/>
        public static ValueTask<HttpResponseMessage> GetMoreEventsResponseAsync(HttpClient client, WebsiteKind websiteKind, int lastId = 0,
            int cityId = -1, IEnumerable<int> specializationIds = null, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetMoreEventsUri(websiteKind, lastId, cityId, specializationIds, apiVersion));
        }

        /// <summary>
        /// Gets more events
        /// <para/>
        /// <remarks>Original name: getEventsMore</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="lastId">Last event's ID of previous query</param>
        /// <param name="cityId">City ID</param>
        /// <param name="specializationIds">Specialization ID's collection</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested events</returns>
        public static async ValueTask<IEnumerable<OsnovaEvent>> GetMoreEventsAsync(HttpClient client, WebsiteKind websiteKind, int lastId = 0,
            int cityId = -1, IEnumerable<int> specializationIds = null, double apiVersion = Core.ApiVersion)
        {
            var response = await GetMoreEventsResponseAsync(client, websiteKind, lastId, cityId, specializationIds, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<OsnovaEvent>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        // TODO: add https://api.vc.ru/v1.9/events/widget, not in the docs, returns array of events

        #endregion

        #endregion
    }
}
