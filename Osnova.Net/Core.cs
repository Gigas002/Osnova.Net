using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using Osnova.Net.Blocks;
using Osnova.Net.Enums;
using Osnova.Net.Exceptions;

#pragma warning disable 1591

namespace Osnova.Net
{
    public static class Core
    {
        #region Constants

        public const string BaseDtfUriString = "https://api.dtf.ru";
        public const string BaseTjournalUriString = "https://api.tjournal.ru";
        public const string BaseVcUriString = "https://api.vc.ru";
        public const string BaseLeonardoUriString = "https://leonardo.osnova.io";

        public const double ApiVersion = 1.9;

        #endregion

        public static JsonSerializerOptions Options { get; } = new()
        {
            Converters =
            {
                new BlockConverter(),
                new WidgetConverter()
                //new ImageBlockDataConverter()
            },
            IgnoreNullValues = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        #region Methods

        public static Uri GetBaseUri(WebsiteKind websiteKind, double apiVersion)
        {
            string invariantVersion = apiVersion.ToString(CultureInfo.InvariantCulture);

            var baseString = websiteKind switch
            {
                WebsiteKind.Dtf => BaseDtfUriString,
                WebsiteKind.Tjournal => BaseTjournalUriString,
                WebsiteKind.Vc => BaseVcUriString,
                _ => throw new NotSupportedException()
            };

            return new Uri($"{baseString}/v{invariantVersion}");
        }

        public static void BuildUri(ref UriBuilder builder, params string[] queriesToAppend)
        {
            foreach (string queryToAppend in queriesToAppend)
            {
                builder.Query = builder.Query is { Length: > 1 }
                    ? $"{builder.Query[1..]}&{queryToAppend}"
                    : queryToAppend;
            }
        }

        public static void CheckResponse(HttpResponseMessage response, HttpStatusCode desiredCode)
        {
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (response.StatusCode != desiredCode)
                throw new InvalidResponseCodeException($"Response code was: {response.StatusCode}," +
                                                       $" expected: {desiredCode}");
        }

        public static HttpClient CreateDefaultClient(string authenticationToken = null)
        {
            HttpClient client = new();

            if (!string.IsNullOrWhiteSpace(authenticationToken)) client.DefaultRequestHeaders.Add("X-Device-Token", authenticationToken);

            client.DefaultRequestHeaders.UserAgent.Add(new("osnova-net-app", "1.0.0"));
            client.DefaultRequestHeaders.UserAgent.Add(new("(PC; Windows 10; ru; 1920x1080)"));
            client.DefaultRequestVersion = HttpVersion.Version20;

            return client;
        }

        public static async ValueTask<HttpResponseMessage> GetResponseFromApiAsync(HttpClient client, Uri requestUri,
                                                                                   HttpStatusCode desiredCode = HttpStatusCode.OK)
        {
            var response = await client.GetAsync(requestUri).ConfigureAwait(false);

            CheckResponse(response, desiredCode);

            return response;
        }

        public static async ValueTask<HttpResponseMessage> PostToApiAsync(HttpClient client, Uri requestUri, HttpContent requestContent,
                                                                          HttpStatusCode desiredCode = HttpStatusCode.OK)
        {
            var response = await client.PostAsync(requestUri, requestContent).ConfigureAwait(false);

            CheckResponse(response, desiredCode);

            return response;
        }

        public static async ValueTask<T> DeserializeOsnovaResponseAsync<T>(HttpResponseMessage response, JsonSerializerOptions options = null)
        {
            if (options == null) options = Options;

            await using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);

            var osnovaResponse = await JsonSerializer.DeserializeAsync<OsnovaResponse<T>>(stream, options).ConfigureAwait(false);

            return osnovaResponse.Result;
        }

        #endregion
    }
}
