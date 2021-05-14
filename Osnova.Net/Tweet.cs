using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class Tweet // WARNING: NOT THE SAME AS TWEETDATA
    {
        #region Properties

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("user")]
        public TwitterUser User { get; set; }

        [JsonPropertyName("retweet_count")]
        public int RetweetCount { get; set; }

        [JsonPropertyName("favorite_count")]
        public int FavoriteCount { get; set; }

        [JsonPropertyName("has_media")]
        public bool HasMedia { get; set; }

        [JsonPropertyName("media")]
        public IEnumerable<TwitterMedia> Media { get; set; }

        [JsonPropertyName("created_at")]
        public long CratedAt { get; set; }

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

        public static async ValueTask<IEnumerable<Tweet>> GetTweetsAsync(HttpClient client, WebsiteKind websiteKind,
               TweetSorting tweetSorting = TweetSorting.Fresh, long count = -1, long offset = -1, double apiVersion = Core.ApiVersion)
        {
            var response = await GetTweetsResponseAsync(client, websiteKind, tweetSorting, count, offset, apiVersion).ConfigureAwait(false);

            return await Core.DeserializeOsnovaResponseAsync<IEnumerable<Tweet>>(response).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #endregion
    }
}
