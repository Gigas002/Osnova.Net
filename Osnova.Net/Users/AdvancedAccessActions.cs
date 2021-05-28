using System.Text.Json.Serialization;

namespace Osnova.Net.Users
{
    public class AdvancedAccessActions
    {
        [JsonPropertyName("read_comments")]
        public bool CanReadComments { get; set; }

        [JsonPropertyName("write_comments")]
        public bool CanWriteComments { get; set; }
    }
}