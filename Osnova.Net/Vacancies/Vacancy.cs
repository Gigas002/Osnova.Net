using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Companies;
using Osnova.Net.Enums;
using Osnova.Net.Filters;

namespace Osnova.Net.Vacancies
{
    /// <summary>
    /// Vacancy
    /// </summary>
    public class Vacancy : IVacancy
    {
        #region Properties

        #region IVacancy implementation

        /// <inheritdoc />
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("salary_to")]
        public int SalaryMax { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("salary_from")]
        public int SalaryMin { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("salary_text")]
        public string SalaryText { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("area")]
        public int Area { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("area_text")]
        public string AreaText { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("schedule")]
        public int Schedule { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("schedule_text")]
        public string ScheduleText { get; set; }

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
        [JsonPropertyName("favoritesCount")]
        public int FavoritesCount { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("isFavorited")]
        public bool IsFavorited { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("company")]
        public Company Company { get; set; }

        #endregion

        #region From real queries

        /// <summary>
        /// Is archived?
        /// </summary>
        [JsonPropertyName("archived")]
        public bool IsArchived { get; set; }

        /// <summary>
        /// Specialization
        /// </summary>
        [JsonPropertyName("specialization")]
        public string Specialization { get; set; }

        #endregion

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion

        #region Methods

        #region GetVacancies

        /// <summary>
        /// Gets an URL to get vacancies
        /// <para/>
        /// <remarks>Original name: getJobs</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/job</returns>
        public static Uri GetVacanciesUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/job");
        }

        /// <inheritdoc cref="GetVacanciesAsync"/>
        public static ValueTask<HttpResponseMessage> GetVacanciesResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                         double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetVacanciesUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Gets vacancies
        /// <para/>
        /// <remarks>Original name: getJobs</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of vacancies</returns>
        public static async ValueTask<IEnumerable<Vacancy>> GetVacanciesAsync(HttpClient client, WebsiteKind websiteKind,
                                                        double apiVersion = Core.ApiVersion)
        {
            using var response = await GetVacanciesResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<Vacancy>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        #region GetMoreVacancies

        /// <summary>
        /// Gets an URL to get more vacancies
        /// <para/>
        /// <remarks>Original name: getJobsMore</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="lastId">Last id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/job/more/0</returns>
        public static Uri GetMoreVacanciesUri(WebsiteKind websiteKind, int lastId = 0, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetVacanciesUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/more/{lastId}");
        }

        /// <inheritdoc cref="GetMoreVacanciesAsync"/>
        public static ValueTask<HttpResponseMessage> GetMoreVacanciesResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              int lastId = 0, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetMoreVacanciesUri(websiteKind, lastId, apiVersion));
        }

        /// <summary>
        /// Gets more vacancies
        /// <para/>
        /// <remarks>Original name: getJobs</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="lastId">Last id</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of vacancies</returns>
        public static async ValueTask<IEnumerable<Vacancy>> GetMoreVacanciesAsync(HttpClient client, WebsiteKind websiteKind,
                                                                             int lastId = 0, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetMoreVacanciesResponseAsync(client, websiteKind, lastId, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<Vacancy>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        #region GetVacancyFilters

        /// <summary>
        /// Gets an URL to get vacancy filters
        /// <para/>
        /// <remarks>Original name: getJobFilters</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/job/filters</returns>
        public static Uri GetVacancyFiltersUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetVacanciesUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/filters");
        }

        /// <inheritdoc cref="GetVacancyFiltersAsync"/>
        public static ValueTask<HttpResponseMessage> GetVacancyFiltersResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                                double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetVacancyFiltersUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Gets vacancy filters
        /// <para/>
        /// <remarks>Original name: getJobFilters</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Dictionary of filters</returns>
        public static async ValueTask<Dictionary<string, IEnumerable<VacancyEventFilter>>> GetVacancyFiltersAsync(HttpClient client, WebsiteKind websiteKind,
                                                                     double apiVersion = Core.ApiVersion)
        {
            using var response = await GetVacancyFiltersResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Dictionary<string, IEnumerable<VacancyEventFilter>>>(response).ConfigureAwait(false);
        }

        #endregion
        
        #endregion
    }
}
