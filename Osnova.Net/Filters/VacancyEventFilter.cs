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

        /// <inheritdoc />
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("title")]
        public string Title { get; set; }

        #endregion

        #region From actual queries

        /// <summary>
        /// Is still active?
        /// </summary>
        [JsonPropertyName("active")]
        public bool IsActive { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Applies to which country?
        /// <para/>
        /// <remarks>Refers to "country_code" property in json</remarks>
        /// </summary>
        [JsonConverter(typeof(CultureInfoJsonConverter))]
        [JsonPropertyName("country_code")]
        public CultureInfo Culture { get; set; }

        /// <summary>
        /// Content count
        /// </summary>
        [JsonPropertyName("content_count")]
        public int ContentCount { get; set; }

        #endregion

        #endregion
    }
}
