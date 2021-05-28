using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Users
{
    public class UserContacts
    {
        [JsonPropertyName("socials")]
        public IEnumerable<SocialAccount> SocialAccounts { get; set; }

        [JsonConverter(typeof(WrongEmptyArrayJsonConverter<WebsiteInfo>))]
        [JsonPropertyName("site")]
        public WebsiteInfo Site { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("contacts")]
        public string Contacts { get; set; }
    }
}