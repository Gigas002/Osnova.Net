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

        [JsonPropertyName("archived")]
        public bool IsArchived { get; set; }

        [JsonPropertyName("specialization")]
        public string Specialization { get; set; }

        #endregion

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion

        #region Methods

        #region GetJobs

        public static Uri GetJobsUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/job");
        }

        public static ValueTask<HttpResponseMessage> GetJobsResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                         double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetJobsUri(websiteKind, apiVersion));
        }

        public static async ValueTask<IEnumerable<Vacancy>> GetJobsAsync(HttpClient client, WebsiteKind websiteKind,
                                                        double apiVersion = Core.ApiVersion)
        {
            using var response = await GetJobsResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<Vacancy>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        #region GetJobsMore

        public static Uri GetJobsMoreUri(WebsiteKind websiteKind, long lastId = 0, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/job/more/{lastId}");
        }

        public static ValueTask<HttpResponseMessage> GetJobsMoreResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              long lastId = 0, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetJobsMoreUri(websiteKind, lastId, apiVersion));
        }

        public static async ValueTask<IEnumerable<Vacancy>> GetJobsMoreAsync(HttpClient client, WebsiteKind websiteKind,
                                                                             long lastId = 0, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetJobsMoreResponseAsync(client, websiteKind, lastId, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<Vacancy>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        #region GetJobFilters

        public static Uri GetJobFiltersUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/job/filters");
        }

        public static ValueTask<HttpResponseMessage> GetJobFiltersResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                                double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetJobFiltersUri(websiteKind, apiVersion));
        }

        public static async ValueTask<EventFilters> GetJobFiltersAsync(HttpClient client, WebsiteKind websiteKind,
                                                                     double apiVersion = Core.ApiVersion)
        {
            using var response = await GetJobFiltersResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<EventFilters>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetVacancies

        public static Uri GetVacanciesUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/vacancies/widget");
        }

        public static ValueTask<HttpResponseMessage> GetVacanciesResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                               double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetVacanciesUri(websiteKind, apiVersion));
        }

        public static async ValueTask<IEnumerable<Vacancy>> GetVacanciesAsync(HttpClient client, WebsiteKind websiteKind,
                                                                    double apiVersion = Core.ApiVersion)
        {
            using var response = await GetVacanciesResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Vacancy>>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion
    }
}
