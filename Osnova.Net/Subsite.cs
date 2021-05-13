using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Subsite : User // TODO: replace older referencies to user and check all properties
    {
        #region Properties

        [JsonPropertyName("rules")]
        public string Rules { get; set; }

        [JsonPropertyName("events_count")]
        public int EventsCount { get; set; }

        #endregion

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

        public static async ValueTask<Subsite> GetSubsiteAsync(HttpClient client, WebsiteKind websiteKind, long subsiteId, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetSubsiteResponseAsync(client, websiteKind, subsiteId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Subsite>(response).ConfigureAwait(false);
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

        public static async ValueTask<IEnumerable<Subsite>> GetSubsitesListAsync(HttpClient client, WebsiteKind websiteKind,
               SubsiteTypes subsiteTypes = SubsiteTypes.Sections, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetSubsitesListResponseAsync(client, websiteKind, subsiteTypes, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Subsite>>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }
}
