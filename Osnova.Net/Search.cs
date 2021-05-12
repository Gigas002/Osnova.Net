using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Search
    {
        #region GetSearch

        public static Uri GetSearchUri(WebsiteKind websiteKind, string query, OrderBy orderBy = OrderBy.Relevant, int page = -1,
                                       double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/search");

            string queryString = $"query={query}";
            string orderByString = $"order_by={orderBy.ToString().ToLowerInvariant()}";
            string pageString = page > 0 ? $"page={page}" : null;

            Core.BuildUri(ref builder, queryString, orderByString, pageString);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetSearchResponseAsync(HttpClient client, WebsiteKind websiteKind, string query,
                                                                            OrderBy orderBy = OrderBy.Relevant, int page = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSearchUri(websiteKind, query, orderBy, page, apiVersion));
        }

        public static async ValueTask<IEnumerable<Entry>> GetSearchAsync(HttpClient client, WebsiteKind websiteKind,
                                                                         string query, OrderBy orderBy = OrderBy.Relevant, int page = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetSearchResponseAsync(client, websiteKind, query, orderBy, page, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetSearchSubsite // TODO: rename to User

        // TODO: test with orderby and page
        public static Uri GetSearchSubsiteUri(WebsiteKind websiteKind, string query, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/search-subsite");

            string queryString = $"q={query}";
            //string orderByString = $"order_by={orderBy.ToString().ToLowerInvariant()}";
            //string pageString = page > 0 ? $"page={page}" : null;

            Core.BuildUri(ref builder, queryString); //, orderByString, pageString);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetSearchSubsiteResponseAsync(HttpClient client, WebsiteKind websiteKind, string query,
                                                                                   double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSearchSubsiteUri(websiteKind, query, apiVersion));
        }

        // TODO: always returns empty array
        public static async ValueTask<IEnumerable<User>> GetSearchSubsiteAsync(HttpClient client, WebsiteKind websiteKind, string query,
            double apiVersion = Core.ApiVersion)
        {
            var response = await GetSearchSubsiteResponseAsync(client, websiteKind, query, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<User>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        #region GetSearchHashtag

        public static Uri GetSearchHashtagUri(WebsiteKind websiteKind, string query, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/search-hashtag");

            string queryString = $"q={query}";

            Core.BuildUri(ref builder, queryString);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetSearchHashtagResponseAsync(HttpClient client, WebsiteKind websiteKind, string query,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetSearchHashtagUri(websiteKind, query, apiVersion));
        }

        public static async ValueTask<IEnumerable<Hashtag>> GetSearchHashtagAsync(HttpClient client, WebsiteKind websiteKind, string query,
            double apiVersion = Core.ApiVersion)
        {
            var response = await GetSearchHashtagResponseAsync(client, websiteKind, query, apiVersion).ConfigureAwait(false);

            var searchResult = await Core.DeserializeOsnovaResponseAsync<SearchResult<Hashtag>>(response).ConfigureAwait(false);

            return searchResult.Items;
        }

        #endregion

        #region GetTag

        public static Uri GetTagUri(WebsiteKind websiteKind, string tag, long lastId, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/tag/{tag}");

            string queryString = $"last_id={lastId}";

            Core.BuildUri(ref builder, queryString);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetTagResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                         string tag, long lastId, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetTagUri(websiteKind, tag, lastId, apiVersion));
        }

        public static async ValueTask<IEnumerable<Entry>> GetTagAsync(HttpClient client, WebsiteKind websiteKind, string tag, long lastId,
                                                        double apiVersion = Core.ApiVersion)
        {
            using var response = await GetTagResponseAsync(client, websiteKind, tag, lastId, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Entry>>(response).ConfigureAwait(false);
        }

        #endregion
    }
}
