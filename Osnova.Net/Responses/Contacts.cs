using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class Contacts
    {
        [JsonPropertyName("socials")]
        public IEnumerable<SocialAccount> Socials { get; set; }

        [JsonPropertyName("site")]
        public Site Site { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// TODO: original name: contacts
        /// </summary>
        [JsonPropertyName("contacts")]
        public string OtherContacts { get; set; }
    }
}