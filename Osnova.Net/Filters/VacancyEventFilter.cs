using System.Text.Json.Serialization;

namespace Osnova.Net.Filters
{
    public class VacancyEventFilter
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("content_count")]
        public int ContentCount { get; set; }
    }
}
