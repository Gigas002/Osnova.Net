using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Entries;
using Osnova.Net.Enums;

namespace Osnova.Net.Popular
{
    public class PopularEntries : PopularBase
    {
        [JsonPropertyName("items")]
        public IEnumerable<Entry> Items { get; set; }

        #region Constructors

        public PopularEntries() : base(ContentType.Entry) { }

        public PopularEntries(IEnumerable<Entry> items) : this() => Items = items;

        #endregion
    }
}
