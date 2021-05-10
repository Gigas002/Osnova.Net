using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Contacts
    {
        [JsonPropertyName("socials")]
        public IEnumerable<SocialAccount> Socials { get; set; }

        [JsonPropertyName("site")]
        public Site Site { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("contacts")]
        public string UserContacts { get; set; }
    }
}