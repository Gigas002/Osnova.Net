using System;
using System.Net.Http;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net.Quiz
{
    public class Quiz
    {
        #region Methods

        #region GET

        #region GetQuizResults

        public static Uri GetQuizResultsUri(WebsiteKind websiteKind, string quizHash, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/quiz/{quizHash}/results");
        }

        public static ValueTask<HttpResponseMessage> GetQuizResultsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            string quizHash, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetQuizResultsUri(websiteKind, quizHash, apiVersion));
        }

        public static async ValueTask<QuizResults> GetQuizResultsAsync(HttpClient client, WebsiteKind websiteKind, string quizHash,
                                                                       double apiVersion = Core.ApiVersion)
        {
            using var response = await GetQuizResultsResponseAsync(client, websiteKind, quizHash, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<QuizResults>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }
}
