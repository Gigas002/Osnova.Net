using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net.WebHooks
{
    /// <summary>
    /// Refers to Watcher spec
    /// </summary>
    public class WebhookWatcher
    {
        #region Properties
        
        /// <summary>
        /// Event ID
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Event name
        /// </summary>
        [JsonPropertyName("event")]
        public string EventName { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }
        
        #endregion

        #region Methods
        
        /// <summary>
        /// Gets default webhooks URL
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/webhooks</returns>
        public static Uri GetDefaultWebhooksUrl(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/webhooks");
        }

        #region GET

        #region GetWebhooksGet

        /// <summary>
        /// Gets an URL to get webhooks "get" url
        /// <para/>
        /// <remarks>Original name: getApiWebhooksGet</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/webhooks/get</returns>
        public static Uri GetWebhooksGetUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultWebhooksUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/get");
        }

        /// <inheritdoc cref="GetWebhooksAsync"/>
        public static ValueTask<HttpResponseMessage> GetWebhooksResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                               double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetWebhooksGetUri(websiteKind, apiVersion));
        }

        /// <summary>
        /// Gets webhooks
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getApiWebhooksGet</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of webhooks</returns>
        public static async ValueTask<IEnumerable<WebhookWatcher>> GetWebhooksAsync(HttpClient client, WebsiteKind websiteKind,
                                                                              double apiVersion = Core.ApiVersion)
        {
            using var response = await GetWebhooksResponseAsync(client, websiteKind, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<WebhookWatcher>>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #region POST

        #region PostApiWebhookAdd

        /// <summary>
        /// Gets an URL to get webhooks "add" url
        /// <para/>
        /// <remarks>Original name: getApiWebhooksAdd</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/webhooks/add</returns>
        public static Uri GetWebhooksAddUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultWebhooksUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/add");
        }

        /// <inheritdoc cref="PostWebhooksAddAsync"/>
        public static async ValueTask<HttpResponseMessage> PostWebhooksAddResponseAsync(HttpClient client, WebsiteKind websiteKind,
            Uri url, string eventName, double apiVersion = Core.ApiVersion)
        {
            var urlContent = new StringContent(url.ToString());
            var eventContent = new StringContent(eventName);
            var requestContent = new MultipartFormDataContent
            {
                { urlContent, "\"url\"" },
                { eventContent, "\"event\"" }
            };

            var response = await Core.PostToApiAsync(client, GetWebhooksAddUri(websiteKind, apiVersion), requestContent).ConfigureAwait(false);

            Core.DisposeHttpContents(urlContent, eventContent, requestContent);

            return response;
        }

        /// <summary>
        /// Add webhook
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getApiWebhooksAdd</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="url">URL</param>
        /// <param name="eventName">Event name</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Collection of added webhooks</returns>

        // TODO: WebhookWatcher overload
        public static async ValueTask<WebhookWatcher> PostWebhooksAddAsync(HttpClient client, WebsiteKind websiteKind,
            Uri url, string eventName, double apiVersion = Core.ApiVersion)
        {
            using var response = await PostWebhooksAddResponseAsync(client, websiteKind, url, eventName, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<WebhookWatcher>(response).ConfigureAwait(false);
        }

        #endregion

        #region PostApiWebhookDelete

        /// <summary>
        /// Gets an URL to get webhooks "del" url
        /// <para/>
        /// <remarks>Original name: getApiWebhooksDel</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/webhooks/del</returns>
        public static Uri GetWebhooksDeleteUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = GetDefaultWebhooksUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/del");
        }

        /// <inheritdoc cref="PostWebhooksDeleteAsync"/>
        public static async ValueTask<HttpResponseMessage> PostWebhooksDeleteResponseAsync(HttpClient client, WebsiteKind websiteKind,
            string eventName, double apiVersion = Core.ApiVersion)
        {
            var eventContent = new StringContent(eventName);
            var requestContent = new MultipartFormDataContent
            {
                { eventContent, "\"event\"" }
            };

            var response = await Core.PostToApiAsync(client, GetWebhooksDeleteUri(websiteKind, apiVersion), requestContent).ConfigureAwait(false);

            Core.DisposeHttpContents(eventContent, requestContent);

            return response;
        }

        /// <summary>
        /// Returns bool, that shows, if webhook is removed
        /// <para/>
        /// <remarks>Requires authentication!
        /// <para/>
        /// Original name: getApiWebhooksDel</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="eventName">Event name</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Is removed successfully?</returns>

        // TODO: WebhookWatcher overload
        public static async ValueTask<bool> PostWebhooksDeleteAsync(HttpClient client, WebsiteKind websiteKind,
                                                                      string eventName, double apiVersion = Core.ApiVersion)
        {
            using var response = await PostWebhooksDeleteResponseAsync(client, websiteKind, eventName, apiVersion).ConfigureAwait(false);

            var deserialized = await Core.DeserializeOsnovaResponseAsync<Dictionary<string, bool>>(response).ConfigureAwait(false);

            return deserialized["success"];
        }

        #endregion

        #endregion

        #endregion
    }
}
