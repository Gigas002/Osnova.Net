using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class ListBlockData
    {
        [JsonPropertyName("items")]
        public IEnumerable<string> Items { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
