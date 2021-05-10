using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Badge
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("background")]
        public string Background { get; set; }

        [JsonPropertyName("border")]
        public string Border { get; set; }
    }
}
