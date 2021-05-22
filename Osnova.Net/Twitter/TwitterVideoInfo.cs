using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    public class TwitterVideoInfo
    {
        [JsonPropertyName("aspect_ratio")]
        public IEnumerable<int> AspectRatio { get; set; }

        [JsonPropertyName("duration_millis")]
        public int DurationMillis { get; set; }

        [JsonPropertyName("variants")]
        public TwitterVideoInfoVariants Variants { get; set; }
    }
}