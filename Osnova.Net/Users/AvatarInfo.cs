using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Users
{
    public class AvatarInfo
    {
        [JsonPropertyName("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}