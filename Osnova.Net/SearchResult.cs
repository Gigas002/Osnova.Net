using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class SearchResult<T>
    {
        [JsonPropertyName("query")]
        public string Query { get; set; }

        [JsonPropertyName("items")]
        public IEnumerable<T> Items { get; set; }

        [JsonPropertyName("last_id")]
        public long LastId { get; set; }
    }
}
