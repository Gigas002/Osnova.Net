using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Enums;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Osnova implementation of <see cref="Tweet"/> v 1.1;
    /// Used for GetTweets method only
    /// <para/>
    /// <remarks>Refers to Tweet spec</remarks>
    /// </summary>
    public class OsnovaTweet : Tweet
    {
        #region Properties

        #region Wrong types

        /// <summary>
        /// Tweet's author
        /// </summary>
        [JsonPropertyName("user")]
        public new OsnovaTwitterUser User { get; set; }

        /// <summary>
        /// Tweet's ID
        /// </summary>
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
        [JsonPropertyName("id")]
        public new long Id { get; set; }

        /// <summary>
        /// Date when this tweet was created
        /// </summary>
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("created_at")]
        public new DateTimeOffset CreatedAt { get; set; }

        #endregion

        #region Osnova only stuff

        /// <summary>
        /// Has media?
        /// </summary>
        [JsonPropertyName("has_media")]
        public bool HasMedia { get; set; }

        /// <summary>
        /// Collection of <see cref="OsnovaTweetMedia"/> elements, if any
        /// </summary>
        [JsonPropertyName("media")]
        public IEnumerable<OsnovaTweetMedia> Media { get; set; }

        #endregion

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion

        #region Methods

        #region GET

        #region GetTweets

        /// <summary>
        /// Gets tweets URL
        /// </summary>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="tweetSorting">Sorting of tweets</param>
        /// <param name="count">Count of tweets</param>
        /// <param name="offset">Tweet offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Ready URL, e.g.: https://api.dtf.ru/v1.9/tweets/fresh?count=10</returns>
        public static Uri GetTweetsUri(WebsiteKind websiteKind, TweetSorting tweetSorting = TweetSorting.Fresh,
                                       int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/tweets/{tweetSorting.ToString().ToLowerInvariant()}");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        /// <inheritdoc cref="GetTweetsAsync"/>
        public static ValueTask<HttpResponseMessage> GetTweetsResponseAsync(HttpClient client, WebsiteKind websiteKind,
                TweetSorting tweetSorting = TweetSorting.Fresh, int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetTweetsUri(websiteKind, tweetSorting, count, offset, apiVersion));
        }

        /// <summary>
        /// Gets tweets
        /// <para/>
        /// <remarks>Original name: getTweets</remarks>
        /// </summary>
        /// <param name="client">Client to send requests</param>
        /// <param name="websiteKind">Kind of website</param>
        /// <param name="tweetSorting">Sorting of tweets</param>
        /// <param name="count">Count of tweets</param>
        /// <param name="offset">Tweet offset</param>
        /// <param name="apiVersion">Target version of API</param>
        /// <returns>Requested tweets</returns>
        public static async ValueTask<IEnumerable<OsnovaTweet>> GetTweetsAsync(HttpClient client, WebsiteKind websiteKind,
               TweetSorting tweetSorting = TweetSorting.Fresh, int count = -1, int offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetTweetsResponseAsync(client, websiteKind, tweetSorting, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<OsnovaTweet>>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }
}
