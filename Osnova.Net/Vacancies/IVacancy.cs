using Osnova.Net.Companies;

namespace Osnova.Net.Vacancies
{
    /// <summary>
    /// Refers to Vacancy spec
    /// </summary>
    public interface IVacancy
    {
        #region Properties

        /// <summary>
        /// Vacancy ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Vacancy title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Max salary value
        /// </summary>
        public int SalaryMax { get; set; }

        /// <summary>
        /// Min salary value
        /// </summary>
        public int SalaryMin { get; set; }

        /// <summary>
        /// Info about salary
        /// </summary>
        public string SalaryText { get; set; }

        /// <summary>
        /// Vacancy area
        /// </summary>
        public int Area { get; set; } // TODO: enum?

        /// <summary>
        /// Area text
        /// </summary>
        public string AreaText { get; set; }

        /// <summary>
        /// Schedule
        /// </summary>
        public int Schedule { get; set; } // TODO: enum?

        /// <summary>
        /// Schedule text
        /// </summary>
        public string ScheduleText { get; set; }

        /// <summary>
        /// Entry id
        /// </summary>
        public int EntryId { get; set; }

        /// <summary>
        /// City id
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// Favorites count
        /// </summary>
        public int FavoritesCount { get; set; }

        /// <summary>
        /// Is favorited?
        /// </summary>
        public bool IsFavorited { get; set; }

        /// <summary>
        /// Company
        /// </summary>
        public Company Company { get; set; }

        #endregion
    }
}
