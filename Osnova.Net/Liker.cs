using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Liker
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonPropertyName("sign")]
        public int Sign { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }
    }
}
