using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Push
    {
        #region GetUserPushTopic

        public static Uri GetUserPushTopicUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/user/push/topic");
        }

        public static ValueTask<HttpResponseMessage> GetUserPushTopicResponseAsync(HttpClient client, WebsiteKind websiteKind,
            double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetUserPushTopicUri(websiteKind, apiVersion));
        }

        public static async ValueTask<string> GetUserPushTopicAsync(HttpClient client, WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetUserPushTopicResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<string>(response).ConfigureAwait(false);
        }

        #endregion
    }
}
