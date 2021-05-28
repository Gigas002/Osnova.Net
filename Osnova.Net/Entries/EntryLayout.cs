using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net.Entries
{
    /// <summary>
    /// Also known as "EntryContent"
    /// </summary>
    public class EntryLayout
    {
        #region Properties

        /// <summary>
        /// Full HTML content of the entry
        /// </summary>
        [JsonPropertyName("html")]
        public string Html { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Gets default layout URL
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/layout</returns>
        public static Uri GetDefaultLayoutUrl(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri(baseUri, "layout");
        }

        #region GET

        #region GetLayout

        // TODO: the same version, as API? Test this
        public static Uri GetLayoutUri(WebsiteKind websiteKind, double version, double apiVersion = Core.ApiVersion)
        {
            var relative = $"{version}";

            return new Uri(GetDefaultLayoutUrl(websiteKind, apiVersion), relative);
        }

        public static ValueTask<HttpResponseMessage> GetLayoutResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                            double version, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetLayoutUri(websiteKind, version, apiVersion));
        }

        public static async ValueTask<EntryLayout> GetLayoutAsync(HttpClient client, WebsiteKind websiteKind, double version, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetLayoutResponseAsync(client, websiteKind, version, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<EntryLayout>(response).ConfigureAwait(false);
        }

        #endregion

        #region GetLayoutHashtag

        public static Uri GetLayoutHashtagUri(WebsiteKind websiteKind, string hashtag, double apiVersion = Core.ApiVersion)
        {
            //var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            //// TODO: original uri: /layout/hashtag/{hashtag} doesn't work at all
            //// TODO: isn't it the SAME as GetLayout?
            //return new Uri($"{baseUri}/layout/{hashtag}");

            var relative = hashtag;

            return new Uri(GetDefaultLayoutUrl(websiteKind, apiVersion), relative);
        }

        public static ValueTask<HttpResponseMessage> GetLayoutHashtagResponseAsync(HttpClient client, WebsiteKind websiteKind,
            string hashtag, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetLayoutHashtagUri(websiteKind, hashtag, apiVersion));
        }

        public static async ValueTask<EntryLayout> GetLayoutHashtagAsync(HttpClient client, WebsiteKind websiteKind, string hashtag, double apiVersion = Core.ApiVersion)
        {
            using var response = await GetLayoutHashtagResponseAsync(client, websiteKind, hashtag, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<EntryLayout>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }
}
