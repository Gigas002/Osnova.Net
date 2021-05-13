using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Vacancy
    {
        #region Properties

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("salary_to")]
        public int SalaryTo { get; set; }

        [JsonPropertyName("salary_from")]
        public int SalaryFrom { get; set; }

        [JsonPropertyName("salary_text")]
        public string SalaryText { get; set; }

        [JsonPropertyName("archived")]
        public bool Archived { get; set; }

        [JsonPropertyName("area")]
        public int Area { get; set; }

        [JsonPropertyName("area_text")]
        public string AreaText { get; set; }

        [JsonPropertyName("schedule")]
        public int Schedule { get; set; }

        [JsonPropertyName("schedule_text")]
        public string ScheduleText { get; set; }

        [JsonPropertyName("entry_id")]
        public long EntryId { get; set; }

        [JsonPropertyName("city_id")]
        public int CityId { get; set; }

        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        [JsonPropertyName("favoritesCount")]
        public long FavoritesCount { get; set; }

        [JsonPropertyName("isFavorited")]
        public bool IsFavorited { get; set; }

        [JsonPropertyName("company")]
        public Company Company { get; set; }

        [JsonPropertyName("specialization")]
        public string Specialization { get; set; }

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

        #endregion
    }
}
