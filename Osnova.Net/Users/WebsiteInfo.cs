using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Users
{
    public class WebsiteInfo
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}