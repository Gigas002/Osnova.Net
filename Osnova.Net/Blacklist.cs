using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Osnova.Net.Enums;
using Osnova.Net.Users;

namespace Osnova.Net
{
    public static class Blacklist
    {
        #region Methods

        #region GET

        #region GetIgnoresHashtags

        public static Uri GetIgnoresHashtagsUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/ignores/hashtags");
        }

        public static ValueTask<HttpResponseMessage> GetIgnoresHashtagsResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                                     double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetIgnoresHashtagsUri(websiteKind, apiVersion));
        }

        public static async ValueTask<IEnumerable<Hashtag>> GetIgnoresHashtagsAsync(HttpClient client, WebsiteKind websiteKind,
                                                                                    double apiVersion = Core.ApiVersion)
        {
            using var response = await GetIgnoresHashtagsResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Hashtag>>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetIgnoresSubsites

        public static Uri GetIgnoresSubsitesUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/ignores/subsites");
        }

        public static ValueTask<HttpResponseMessage> GetIgnoresSubsitesResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetIgnoresSubsitesUri(websiteKind, apiVersion));
        }

        public static async ValueTask<IEnumerable<User>> GetIgnoresSubsitesAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            using var response = await GetIgnoresSubsitesResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<User>>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }
}
