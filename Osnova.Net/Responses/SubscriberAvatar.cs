using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class SubscriberAvatar
    {
        [JsonPropertyName("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}