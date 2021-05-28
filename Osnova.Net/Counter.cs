using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    // TODO: obsolete this
    public class Counter
    {
        [JsonPropertyName("count")]
        public long Count { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }
    }
}
