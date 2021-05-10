using System.Text.Json.Serialization;

namespace Osnova.Net.Blocks
{
    public class MediaItemBlock : Block
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("image")]
        public Block Image { get; set; }
    }
}
