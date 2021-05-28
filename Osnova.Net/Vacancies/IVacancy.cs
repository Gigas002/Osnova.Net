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

        public int Area { get; set; } // TODO: enum?

        public string AreaText { get; set; }

        public int Schedule { get; set; }

        public string ScheduleText { get; set; }

        public int EntryId { get; set; }

        public int CityId { get; set; }

        public string CityName { get; set; }

        public int FavoritesCount { get; set; }

        public bool IsFavorited { get; set; }

        public Company Company { get; set; }

        #endregion
    }
}
