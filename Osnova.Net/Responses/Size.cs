using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class Size
    {
        [JsonPropertyName("width")]
        public long Width { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("ratio")]
        public long Ratio { get; set; }
    }
}
