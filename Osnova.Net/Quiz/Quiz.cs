using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Enums;
using Osnova.Net.Users;

namespace Osnova.Net.Quiz
{
    /// <summary>
    /// Quiz
    /// </summary>
    public class Quiz
    {
        #region Properties

        /// <summary>
        /// Collection of hash/QuizResults
        /// </summary>
        [JsonPropertyName("items")]
        public Dictionary<string, QuizResult> Items { get; set; }

        /// <summary>
        /// Quiz winner's hash
        /// </summary>
        [JsonPropertyName("winner")]
        public string Winner { get; set; }

        /// <summary>
        /// Voted result hash
        /// </summary>
        [JsonPropertyName("userVoted")]
        public string UserVoted { get; set; }

        [JsonPropertyName("randomVotedUsers")]
        public Dictionary<string, IEnumerable<User>> RandomVotedUsers { get; set; } // TODO: find this

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }
        
        #endregion

        #region Methods
        
        /// <summary>
        /// Gets default quiz URL
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/quiz</returns>
        public static Uri GetDefaultQuizUrl(WebsiteKind websiteKind, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            return new Uri($"{baseUri}/quiz");
        }

        #region GET

        #region GetQuizResults

        /// <summary>
        /// Gets an URL to get quiz results
        /// <para/>
        /// <remarks>Original name: getQuizResults</remarks>
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="quizHash">Quiz hash</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/quiz/hash/results</returns>
        public static Uri GetQuizResultsUri(WebsiteKind websiteKind, string quizHash, double apiVersion = Core.ApiVersion)
        {
            string relative = $"{quizHash}/results";

            var baseUri = GetDefaultQuizUrl(websiteKind, apiVersion);

            return new Uri($"{baseUri}/{relative}");
        }

        /// <inheritdoc cref="GetQuizResultsAsync"/>
        public static ValueTask<HttpResponseMessage> GetQuizResultsResponseAsync(HttpClient client, WebsiteKind websiteKind,
            string quizHash, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetQuizResultsUri(websiteKind, quizHash, apiVersion));
        }

        /// <summary>
        /// Gets quiz results
        /// <para/>
        /// <remarks>Original name: getQuizResults</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="quizHash">Quiz hash</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested quiz's results</returns>
        public static async ValueTask<Quiz> GetQuizResultsAsync(HttpClient client, WebsiteKind websiteKind, string quizHash,
                                                                       double apiVersion = Core.ApiVersion)
        {
            using var response = await GetQuizResultsResponseAsync(client, websiteKind, quizHash, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<Quiz>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }
}
