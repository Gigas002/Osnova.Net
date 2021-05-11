using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Authentication
    {
        #region PostAuthQr

        public static Uri GetAuthQrUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/auth/qr");
        }

        public static async ValueTask<HttpResponseMessage> PostAuthQrGetResponseAsync(HttpClient client, WebsiteKind websiteKind,
            string token, double apiVersion = Core.ApiVersion)
        {
            var tokenContent = new StringContent(token);

            var requestContent = new MultipartFormDataContent
            {
                { tokenContent, "\"token\"" }
            };

            var response = await Core.PostToApiAsync(client, GetAuthQrUri(websiteKind, apiVersion), requestContent).ConfigureAwait(false);

            tokenContent.Dispose();
            requestContent.Dispose();

            return response;
        }

        public static async ValueTask<string> PostAuthQrGetTokenAsync(HttpClient client, WebsiteKind websiteKind, string token,
                                                                      double apiVersion = Core.ApiVersion)
        {
            using var response = await PostAuthQrGetResponseAsync(client, websiteKind, token, apiVersion).ConfigureAwait(false);

            return response.Headers.FirstOrDefault(h => h.Key == "x-device-token").Value.FirstOrDefault();
        }

        #endregion

        #region PostAuthSocial

        public static Uri GetAuthSocialUri(WebsiteKind websiteKind, SocialType socialType, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/auth/social/{socialType}");
        }

        public static async ValueTask<HttpResponseMessage> PostAuthSocialGetResponseAsync(HttpClient client, WebsiteKind websiteKind,
            SocialType socialType, string token, string email, bool linking = false, double apiVersion = Core.ApiVersion)
        {
            var tokenContent = new StringContent(token);
            var emailContent = new StringContent(email);
            var linkingContent = new StringContent($"{Convert.ToInt32(linking)}");

            var requestContent = new MultipartFormDataContent
            {
                { tokenContent, "\"token\"" },
                { emailContent, "\"email\"" },
                { linkingContent, "\"linking\"" }
            };

            var response = await Core.PostToApiAsync(client, GetAuthSocialUri(websiteKind, socialType, apiVersion), requestContent).ConfigureAwait(false);

            tokenContent.Dispose();
            emailContent.Dispose();
            linkingContent.Dispose();
            requestContent.Dispose();

            return response;
        }

        public static async ValueTask<string> PostAuthSocialGetTokenAsync(HttpClient client, WebsiteKind websiteKind,
               SocialType socialType, string token, string email, bool linking = false, double apiVersion = Core.ApiVersion)
        {
            using var response = await PostAuthSocialGetResponseAsync(client, websiteKind, socialType, token, email, linking,
                                                                      apiVersion).ConfigureAwait(false);

            return response.Headers.FirstOrDefault(h => h.Key == "x-device-token").Value.FirstOrDefault();
        }

        #endregion

        #region PostAuthLogin

        public static Uri GetAuthLoginUri(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/auth/login");
        }

        public static async ValueTask<HttpResponseMessage> PostAuthLoginGetResponseAsync(HttpClient client, WebsiteKind websiteKind,
                                                                         string login, string password, double apiVersion = Core.ApiVersion)
        {
            var loginContent = new StringContent(login);
            var passwordContent = new StringContent(password);

            var requestContent = new MultipartFormDataContent
            {
                { loginContent, "\"login\"" },
                { passwordContent, "\"password\"" }
            };

            var response = await Core.PostToApiAsync(client, GetAuthLoginUri(websiteKind, apiVersion), requestContent).ConfigureAwait(false);

            loginContent.Dispose();
            passwordContent.Dispose();
            requestContent.Dispose();

            return response;
        }

        public static async ValueTask<string> PostAuthLoginGetTokenAsync(HttpClient client, WebsiteKind websiteKind, string login,
                                                                      string password, double apiVersion = Core.ApiVersion)
        {
            using var response = await PostAuthLoginGetResponseAsync(client, websiteKind, login, password, apiVersion).ConfigureAwait(false);

            return response.Headers.FirstOrDefault(h => h.Key == "x-device-token").Value.FirstOrDefault();
        }

        #endregion
    }
}
