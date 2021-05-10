using System;
using System.Net.Http;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Authentication
    {
        #region PostAuthLogin

        public static Uri GetAuthLoginUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/auth/login");
        }

        public static ValueTask<HttpResponseMessage> PostAuthLoginGetResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                         string login, string password, double apiVersion = Core.ApiVersion)
        {
            using var loginContent = new StringContent(login);
            using var passwordContent = new StringContent(password);

            using var requestContent = new MultipartFormDataContent
            {
                { loginContent, "\"login\"" },
                { passwordContent, "\"password\"" }
            };

            return Core.PostToApiAsync(client, GetAuthLoginUri(websiteKind, apiVersion), requestContent);
        }

        public static async ValueTask<User> PostAuthLoginGetUserAsync(HttpClient client, WebsiteKind websiteKind, string login,
                                                                      string password, double apiVersion = Core.ApiVersion)
        {
            using var response = await PostAuthLoginGetResponseAsync(client, websiteKind, login, password, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<User>(response).ConfigureAwait(false);
        }

        #endregion
    }
}
