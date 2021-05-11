using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Timeline
    {
        #region GetTimeline

        public static Uri GetTimelineUri(WebsiteKind websiteKind, TimelineCategory category, TimelineSorting sorting,
                                         int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/timeline/{category}/{sorting}");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetTimelineResponseAsync(HttpClient client, WebsiteKind websiteKind, TimelineCategory category,
                      TimelineSorting sorting, int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetTimelineUri(websiteKind, category, sorting, count, offset, apiVersion));
        }

        public static async ValueTask<IEnumerable<Entry>> GetTimelineAsync(HttpClient client, WebsiteKind websiteKind, TimelineCategory category,
                            TimelineSorting sorting, int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetTimelineResponseAsync(client, websiteKind, category, sorting, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetTimelineByHashtag

        public static Uri GetTimelineByHashtagUri(WebsiteKind websiteKind, string hashtag,
               TimelineCategory category = TimelineCategory.MainPage, TimelineSorting sorting = TimelineSorting.Recent,
               int limit = -1, int lastId = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/timeline/{category}/{sorting}");

            string limitQuery = limit > -1 ? $"limit={limit}" : null;
            string lastIdQuery = lastId > -1 ? $"last_id={lastId}" : null;

            Core.BuildUri(ref builder, hashtag, limitQuery, lastIdQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetTimelineByHashtagResponseAsync(HttpClient client, WebsiteKind websiteKind,
            string hashtag, TimelineCategory category, TimelineSorting sorting, int limit = -1, int lastId = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetTimelineByHashtagUri(websiteKind, hashtag, category, sorting, limit, lastId, apiVersion));
        }

        public static async ValueTask<IEnumerable<Entry>> GetTimelineByHashtagAsync(HttpClient client, WebsiteKind websiteKind, string hashtag,
            TimelineCategory category,
                                                                           TimelineSorting sorting, int limit = -1, int lastId = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetTimelineByHashtagResponseAsync(client, websiteKind, hashtag, category, sorting, limit, lastId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetTimelineNews

        public static Uri GetTimelineNewsUri(WebsiteKind websiteKind, TimelineSorting sorting,
                                             int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/news/default/{sorting}");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetTimelineNewsResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              TimelineSorting sorting, int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetTimelineNewsUri(websiteKind, sorting, count, offset, apiVersion));
        }

        public static async ValueTask<IEnumerable<Entry>> GetTimelineNewsAsync(HttpClient client, WebsiteKind websiteKind,
                                                                               TimelineSorting sorting, int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetTimelineNewsResponseAsync(client, websiteKind, sorting, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion
    }
}
