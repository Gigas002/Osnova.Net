using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net
{
    public class MediaItem
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("image")]
        public ImageBlock Image { get; set; }
    }
}
