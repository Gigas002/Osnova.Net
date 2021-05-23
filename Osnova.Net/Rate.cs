using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Rate
    {
        [JsonPropertyName("rate")]
        public string RateString { get; set; }

        [JsonPropertyName("change")]
        public double Change { get; set; }

        [JsonPropertyName("sym")]
        public string Sym { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }
    }
}
