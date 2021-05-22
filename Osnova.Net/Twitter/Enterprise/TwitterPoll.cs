using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter.Enterprise
{
    /// <summary>
    /// 1.1
    /// </summary>
    public class TwitterPoll
    {
        [JsonPropertyName("options")]
        public IEnumerable<TwitterPollOption> Options { get; set; }

        [JsonPropertyName("end_datetime")]
        public string EndDatetime { get; set; }

        [JsonPropertyName("duration_minutes")]
        public int DurationMinutes { get; set; }
    }
}
