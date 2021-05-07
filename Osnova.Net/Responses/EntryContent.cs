using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class EntryContent
    {
        [JsonPropertyName("html")]
        public string Html { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
