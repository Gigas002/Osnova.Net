using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class ExternalService
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
