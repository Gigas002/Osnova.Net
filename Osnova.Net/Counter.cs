using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Counter
    {
        [JsonPropertyName("count")]
        public long Count { get; set; }
    }
}
