using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// OsnovaShit
    /// </summary>
    public class OsnovaTweet
    {
        #region Properties

        #region Same as 1.1 spec Tweet

        // ok
        [JsonPropertyName("text")]
        public string Text { get; set; }

        // kind of
        [JsonPropertyName("user")]
        public OsnovaTwitterUser User { get; set; }

        // ok
        [JsonPropertyName("retweet_count")]
        public int RetweetCount { get; set; }

        // ok
        [JsonPropertyName("favorite_count")]
        public int FavoriteCount { get; set; }

        #endregion

        #region Wrong types

        // long != string
        [JsonPropertyName("id")]
        public string Id { get; set; }

        // string != long
        [JsonPropertyName("created_at")]
        public long CreatedAt { get; set; }

        #endregion

        #region Wtf is this

        // nope
        [JsonPropertyName("has_media")]
        public bool HasMedia { get; set; }

        // nope
        [JsonPropertyName("media")]
        public IEnumerable<OsnovaTweetMedia> Media { get; set; }

        #endregion

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
