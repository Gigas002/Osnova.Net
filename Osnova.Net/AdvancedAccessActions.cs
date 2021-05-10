using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class AdvancedAccessActions
    {
        [JsonPropertyName("read_comments")]
        public bool ReadComments { get; set; }

        [JsonPropertyName("write_comments")]
        public bool WriteComments { get; set; }
    }
}