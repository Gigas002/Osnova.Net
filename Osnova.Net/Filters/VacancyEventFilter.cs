using System.Globalization;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;
using Osnova.Net.OsnovaEvents;
using Osnova.Net.Vacancies;

namespace Osnova.Net.Filters
{
    /// <summary>
    /// Fits for both <see cref="OsnovaEvent"/> and <see cref="Vacancy"/>
    /// </summary>
    public class VacancyEventFilter : IEventFilter
    {
        #region Properties

        #region IEventFilter implementation

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        #endregion

        #region From actual queries

        [JsonPropertyName("active")]
        public bool IsActive { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonConverter(typeof(CultureInfoJsonConverter))]
        [JsonPropertyName("country_code")]
        public CultureInfo Culture { get; set; }

        [JsonPropertyName("content_count")]
        public int ContentCount { get; set; }

        #endregion

        #endregion
    }
}
