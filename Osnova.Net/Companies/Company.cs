using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Companies
{
    /// <inheritdoc cref="ICompany"/>
    public class Company : ICompany
    {
        #region Properties

        #region ICompany implementation

        /// <inheritdoc />
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("logo")]
        public Uri Logo { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("is_verified")]
        public bool IsVerified { get; set; }

        #endregion

        /// <summary>
        /// Company type (IT, etc)
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; } // TODO: enum?

        #endregion
    }
}
