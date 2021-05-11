using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Vacancy
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("salary_to")]
        public int SalaryTo { get; set; }

        [JsonPropertyName("salary_from")]
        public int SalaryFrom { get; set; }

        [JsonPropertyName("salary_text")]
        public string SalaryText { get; set; }

        [JsonPropertyName("archived")]
        public bool Archived { get; set; }

        [JsonPropertyName("area")]
        public int Area { get; set; }

        [JsonPropertyName("area_text")]
        public string AreaText { get; set; }

        [JsonPropertyName("schedule")]
        public int Schedule { get; set; }

        [JsonPropertyName("schedule_text")]
        public string ScheduleText { get; set; }

        [JsonPropertyName("entry_id")]
        public long EntryId { get; set; }

        [JsonPropertyName("city_id")]
        public int CityId { get; set; }

        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        [JsonPropertyName("favoritesCount")]
        public long FavoritesCount { get; set; }

        [JsonPropertyName("isFavorited")]
        public bool IsFavorited { get; set; }

        [JsonPropertyName("company")]
        public Company Company { get; set; }

        [JsonPropertyName("specialization")]
        public string Specialization { get; set; }
    }
}
