using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Users
{
    public class MentionedUser : User
    {
        [JsonPropertyName("text")]
        public new string Name { get; set; }

        [JsonPropertyName("img")]
        public new Uri AvatarUrl { get; set; }

        [JsonPropertyName("is_me")]
        public bool IsMe { get; set; }
    }
}
