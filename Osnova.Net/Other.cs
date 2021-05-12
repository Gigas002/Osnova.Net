using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Osnova.Net.Blocks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Other
    {
        #region GetLocate

        public static Uri GetLocateUri(WebsiteKind websiteKind, Uri locateUri, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/locate");

            string locateUriString = $"url={locateUri}";

            Core.BuildUri(ref builder, locateUriString);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetLocateResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                            Uri locateUri, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetLocateUri(websiteKind, locateUri, apiVersion));
        }

        public static async ValueTask<Block> GetLocateAsync(HttpClient client, WebsiteKind websiteKind,
                                                                          Uri locateUri, double apiVersion = Core.ApiVersion)
        {
            var response = await GetLocateResponseAsync(client, websiteKind, locateUri, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Block>(response).ConfigureAwait(false);
        }

        #endregion
    }
}
