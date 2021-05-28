using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net
{
    public class AudioInfo
    {
        [JsonPropertyName("bitrate")]
        public int Bitrate { get; set; }

        [JsonPropertyName("duration")]
        public double Duration { get; set; }

        [JsonPropertyName("channel")]
        public AudioChannel Channel { get; set; }

        [JsonPropertyName("framesCount")]
        public int FramesCount { get; set; }

        [JsonPropertyName("format")]
        public AudioExtension Extension { get; set; }

        [JsonPropertyName("listens_count")]
        public int ListensCount { get; set; }
    }
}
