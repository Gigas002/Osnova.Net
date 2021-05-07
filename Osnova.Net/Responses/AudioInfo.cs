using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class AudioInfo
    {
        [JsonPropertyName("bitrate")]
        public long BitRate { get; set; }

        [JsonPropertyName("duration")]
        public double Duration { get; set; }

        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        [JsonPropertyName("framesCount")]
        public int FramesCount { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("listens_count")]
        public int ListensCount { get; set; }
    }
}
