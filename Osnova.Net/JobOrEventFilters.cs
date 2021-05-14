using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class JobOrEventFilters
    {
        [JsonPropertyName("area")]
        public IEnumerable<JobOrEventFilter> Areas { get; set; }

        [JsonPropertyName("cities")]
        public IEnumerable<JobOrEventFilter> Cities { get; set; }

        [JsonPropertyName("schedule")]
        public IEnumerable<JobOrEventFilter> Schedules { get; set; }

        [JsonPropertyName("specializations")]
        public IEnumerable<JobOrEventFilter> Specializations { get; set; }
    }
}
