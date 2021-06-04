using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Users
{
    /// <summary>
    /// User's contacts
    /// </summary>
    public class UserContacts
    {
        #region Properties
        
        /// <summary>
        /// Collection of user's external social accounts
        /// </summary>
        [JsonPropertyName("socials")]
        public IEnumerable<SocialAccount> SocialAccounts { get; set; }

        /// <summary>
        /// External website's info
        /// </summary>
        [JsonConverter(typeof(WrongEmptyArrayJsonConverter<WebsiteInfo>))]
        [JsonPropertyName("site")]
        public WebsiteInfo Site { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Contacts
        /// </summary>
        [JsonPropertyName("contacts")]
        public string Contacts { get; set; }
        
        #endregion
    }
}