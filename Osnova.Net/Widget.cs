using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Comments;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Widget
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("item_type")]
        public string ItemType { get; set; }

        [JsonPropertyName("items")]
        public object Items { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        public static Type GetItemsType(string itemType) => itemType switch
        {
            "content" => typeof(IEnumerable<Entry>),
            "comment" => typeof(IEnumerable<Comment>),
            _ => typeof(object)
        };

        #region GetRates

        public static Uri GetRatesUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/rates");
        }

        public static ValueTask<HttpResponseMessage> GetRatesResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                           double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetRatesUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Requires authentication!
        /// </summary>
        /// <param name="client"></param>
        /// <param name="websiteKind"></param>
        /// <param name="apiVersion"></param>
        /// <returns></returns>
        public static async ValueTask<Dictionary<string, Rate>> GetRatesAsync(HttpClient client, WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetRatesResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Dictionary<string, Rate>>(response).ConfigureAwait(false);
        }

        #endregion
    }
}
