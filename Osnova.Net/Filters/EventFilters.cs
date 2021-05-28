using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Filters
{
    public class EventFilters
    {
        [JsonPropertyName("area")]
        public IEnumerable<VacancyEventFilter> Areas { get; set; }

        [JsonPropertyName("cities")]
        public IEnumerable<VacancyEventFilter> Cities { get; set; }

        [JsonPropertyName("schedule")]
        public IEnumerable<VacancyEventFilter> Schedules { get; set; }

        [JsonPropertyName("specializations")]
        public IEnumerable<VacancyEventFilter> Specializations { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }
    }
}
