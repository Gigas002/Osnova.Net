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
    /// OsnovaShit
    /// Used for GetTweets method only
    /// Refers to Tweet spec
    /// </summary>
    public class OsnovaTweet : Tweet
    {
        #region Properties

        #region Wrong types

        [JsonPropertyName("user")]
        public new OsnovaTwitterUser User { get; set; }

        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
        [JsonPropertyName("id")]
        public new long Id { get; set; }

        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("created_at")]
        public new DateTimeOffset CreatedAt { get; set; }

        #endregion

        #region Osnova only stuff

        [JsonPropertyName("has_media")]
        public bool HasMedia { get; set; }

        [JsonPropertyName("media")]
        public IEnumerable<OsnovaTweetMedia> Media { get; set; }

        #endregion

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion

        #region Methods

        #region GET

        #region GetTweets

        public static Uri GetTweetsUri(WebsiteKind websiteKind, TweetSorting tweetSorting = TweetSorting.Fresh,
                                       long count = -1, long offset = -1, double apiVersion = Core.ApiVersion)
        {
            var baseUri = Core.GetBaseUri(websiteKind, apiVersion);

            UriBuilder builder = new($"{baseUri}/tweets/{tweetSorting.ToString().ToLowerInvariant()}");

            string countQuery = count > -1 ? $"count={count}" : null;
            string offsetQuery = offset > -1 ? $"offset={offset}" : null;

            Core.BuildUri(ref builder, countQuery, offsetQuery);

            return builder.Uri;
        }

        public static ValueTask<HttpResponseMessage> GetTweetsResponseAsync(HttpClient client, WebsiteKind websiteKind,
                TweetSorting tweetSorting = TweetSorting.Fresh, long count = -1, long offset = -1, double apiVersion = Core.ApiVersion)
        {
            return Core.GetResponseFromApiAsync(client, GetTweetsUri(websiteKind, tweetSorting, count, offset, apiVersion));
        }

        public static async ValueTask<IEnumerable<OsnovaTweet>> GetTweetsAsync(HttpClient client, WebsiteKind websiteKind,
               TweetSorting tweetSorting = TweetSorting.Fresh, long count = -1, long offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetTweetsResponseAsync(client, websiteKind, tweetSorting, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<OsnovaTweet>>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }
}
