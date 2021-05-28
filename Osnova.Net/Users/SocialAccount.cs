using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Users
{
    public class SocialAccount
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; } // TODO: enum

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}
