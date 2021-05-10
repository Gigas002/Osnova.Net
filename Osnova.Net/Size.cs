using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Size
    {
        [JsonPropertyName("width")]
        public long Width { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("ratio")]
        public double Ratio { get; set; }
    }
}
