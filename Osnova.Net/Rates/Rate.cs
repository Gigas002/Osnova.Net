using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Enums;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Rates
{
    /// <summary>
    /// Currency rate
    /// </summary>
    public class Rate
    {
        /// <summary>
        /// Rate value
        /// </summary>
        [JsonConverter(typeof(RateValueJsonConverter))]
        [JsonPropertyName("rate")]
        public double Value { get; set; }

        /// <summary>
        /// Change
        /// </summary>
        [JsonPropertyName("change")]
        public double Change { get; set; }

        /// <summary>
        /// Currency symbol
        /// </summary>
        [JsonPropertyName("sym")]
        public string Symbol { get; set; }

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
