using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class SocialAccount
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("username")]
        public string UserName { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}
