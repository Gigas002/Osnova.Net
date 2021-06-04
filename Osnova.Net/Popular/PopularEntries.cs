using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Entries;
using Osnova.Net.Enums;

namespace Osnova.Net.Popular
{
    /// <summary>
    /// Popular entries
    /// </summary>
    public class PopularEntries : PopularBase
    {
        #region Properties
        
        /// <summary>
        /// Collection of popular entries
        /// </summary>
        [JsonPropertyName("items")]
        public IEnumerable<Entry> Items { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates new empty <see cref="PopularEntries"/> object
        /// </summary>
        public PopularEntries() : base(ContentType.Entry) { }

        /// <summary>
        /// Creates new <see cref="PopularEntries"/> object with items
        /// </summary>
        /// <param name="items">Collection of popular entries</param>
        public PopularEntries(IEnumerable<Entry> items) : this() => Items = items;

        #endregion
    }
}
