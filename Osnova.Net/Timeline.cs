using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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
    }
}
