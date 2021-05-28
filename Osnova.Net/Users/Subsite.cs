using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Osnova.Net.Entries;
using Osnova.Net.Enums;
using Osnova.Net.Vacancies;

namespace Osnova.Net.Users
{
    // TODO: obsolete this?
    public static class Subsite
    {
        #region Methods

        #region GET

        #region GetSubsite

        public static Uri GetSubsiteUri(WebsiteKind websiteKind, long subsiteId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/subsite/{subsiteId}");
        }

        public static ValueTask<HttpResponseMessage> GetSubsiteResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                             long subsiteId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSubsiteUri(websiteKind, subsiteId, apiVersion));
        }

        public static async ValueTask<User> GetSubsiteAsync(HttpClient client, WebsiteKind websiteKind, long subsiteId, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetSubsiteResponseAsync(client, websiteKind, subsiteId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<User>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetSubsiteTimeline

        public static Uri GetSubsiteTimelineUri(WebsiteKind websiteKind, long subsiteId,
               SubsiteTimelineSorting subsiteTimelineSorting = SubsiteTimelineSorting.Default,
               int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/subsite/{subsiteId}/timeline{Core.ConvertSubsiteTimelineSorting(subsiteTimelineSorting)}");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetSubsiteTimelineResponseAsync(HttpClient client, WebsiteKind websiteKind,
            long subsiteId, SubsiteTimelineSorting subsiteTimelineSorting = SubsiteTimelineSorting.Default,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSubsiteTimelineUri(websiteKind, subsiteId, subsiteTimelineSorting, count,
                                                                              offset, apiVersion));
        }

        public static async ValueTask<IEnumerable<Entry>> GetSubsiteTimelineAsync(HttpClient client, WebsiteKind websiteKind,
            long subsiteId, SubsiteTimelineSorting subsiteTimelineSorting = SubsiteTimelineSorting.Default,
            int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetSubsiteTimelineResponseAsync(client, websiteKind, subsiteId, subsiteTimelineSorting, count,
                                                                 offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetSubsitesList

        public static Uri GetSubsitesListUri(WebsiteKind websiteKind, SubsiteTypes subsiteTypes = SubsiteTypes.Sections,
                                             double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/subsites_list/{subsiteTypes.ToString().ToLowerInvariant()}");
        }

        public static ValueTask<HttpResponseMessage> GetSubsitesListResponseAsync(HttpClient client, WebsiteKind websiteKind,
            SubsiteTypes subsiteTypes = SubsiteTypes.Sections, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSubsitesListUri(websiteKind, subsiteTypes, apiVersion));
        }

        public static async ValueTask<IEnumerable<User>> GetSubsitesListAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              SubsiteTypes subsiteTypes = SubsiteTypes.Sections, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetSubsitesListResponseAsync(client, websiteKind, subsiteTypes, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<User>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetSubsiteVacancies

        public static Uri GetSubsiteVacanciesUri(WebsiteKind websiteKind, long companyId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/subsite/{companyId}/vacancies");
        }

        public static ValueTask<HttpResponseMessage> GetSubsiteVacanciesResponseAsync(HttpClient client, WebsiteKind websiteKind,
            long companyId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSubsiteVacanciesUri(websiteKind, companyId, apiVersion));
        }

        public static async ValueTask<IEnumerable<Vacancy>> GetSubsiteVacanciesAsync(HttpClient client, WebsiteKind websiteKind,
            long companyId, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetSubsiteVacanciesResponseAsync(client, websiteKind, companyId, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<Vacancy>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        #region GetSubsiteVacanciesMore

        public static Uri GetSubsiteVacanciesMoreUri(WebsiteKind websiteKind, long companyId,
                                                     long lastId = 0, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/subsite/{companyId}/vacancies/more/{lastId}");
        }

        public static ValueTask<HttpResponseMessage> GetSubsiteVacanciesMoreResponseAsync(HttpClient client, WebsiteKind websiteKind,
            long companyId, long lastId = 0, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSubsiteVacanciesMoreUri(websiteKind, companyId, lastId, apiVersion));
        }

        public static async ValueTask<IEnumerable<Vacancy>> GetSubsiteVacanciesMoreAsync(HttpClient client, WebsiteKind websiteKind,
            long companyId, long lastId = 0, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetSubsiteVacanciesMoreResponseAsync(client, websiteKind, companyId, lastId, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<Vacancy>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        // TODO: always 403

        #region GetSubsiteSubscribe

        public static Uri GetSubsiteSubscribeUri(WebsiteKind websiteKind, long subsiteId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/subsite/{subsiteId}/subscribe");
        }

        public static ValueTask<HttpResponseMessage> GetSubsiteSubscribeResponseAsync(HttpClient client, WebsiteKind websiteKind,
            long subsiteId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSubsiteSubscribeUri(websiteKind, subsiteId, apiVersion));
        }

        public static async ValueTask<bool> GetSubsiteSubscribeAsync(HttpClient client, WebsiteKind websiteKind,
                                                                     long subsiteId, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetSubsiteSubscribeResponseAsync(client, websiteKind, subsiteId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<bool>(response).ConfigureAwait(false);
        }

        #endregion

        // TODO: always 403

        #region GetSubsiteUnsubscribe

        public static Uri GetSubsiteUnsubscribeUri(WebsiteKind websiteKind, long subsiteId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/subsite/{subsiteId}/unsubscribe");
        }

        public static ValueTask<HttpResponseMessage> GetSubsiteUnsubscribeResponseAsync(HttpClient client, WebsiteKind websiteKind,
            long subsiteId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSubsiteUnsubscribeUri(websiteKind, subsiteId, apiVersion));
        }

        public static async ValueTask<bool> GetSubsiteUnsubscribeAsync(HttpClient client, WebsiteKind websiteKind,
                                                                     long subsiteId, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetSubsiteUnsubscribeResponseAsync(client, websiteKind, subsiteId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<bool>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }
}
