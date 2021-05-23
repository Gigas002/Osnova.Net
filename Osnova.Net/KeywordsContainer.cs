using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class KeywordsContainer
    {
        [JsonPropertyName("keywords")]
        public IEnumerable<string> Keywords { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }
    }
}
