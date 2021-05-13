using System;
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
    }
}
