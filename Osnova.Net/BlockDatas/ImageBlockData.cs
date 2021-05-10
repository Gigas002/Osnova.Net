using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class ImageBlockData : BlockData
    {
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; } // Not a Guid, sometimes it's a shitty string...

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("external_service")]
        public JsonElement ExternalService { get; set; } // TODO: в рот ёб того урода, который сюда пустой массив запихнул
    }
}
