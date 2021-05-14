using System;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class MentionedUser
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("img")]
        public Uri Image { get; set; }

        [JsonPropertyName("is_me")]
        public bool IsMe { get; set; }

        [JsonPropertyName("is_verified")]
        public bool IsVerified { get; set; }
    }
}
