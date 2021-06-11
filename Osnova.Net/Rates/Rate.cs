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
        #region Properties

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

        #endregion

        #region Methods

        /// <summary>
        /// Gets default rates URL
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/rates</returns>
        public static Uri GetDefaultRatesUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/rates");
        }

        #region GET

        #region GetRates
        
        /// <inheritdoc cref="GetRatesAsync"/>
        public static ValueTask<HttpResponseMessage> GetRatesResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                           double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetDefaultRatesUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Gets rates
        /// <para/>
        /// <remarks>Original name: getRates</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested rates</returns>
        public static async ValueTask<Dictionary<string, Rate>> GetRatesAsync(HttpClient client, WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetRatesResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Dictionary<string, Rate>>(response).ConfigureAwait(false);
        }

        #endregion
        
        #endregion

        #endregion
    }
}
