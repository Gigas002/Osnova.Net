using Osnova.Net.Companies;

namespace Osnova.Net.OsnovaEvents
{
    /// <summary>
    /// Refers to Event spec
    /// </summary>
    public interface IOsnovaEvent
    {
        #region Properties

        /// <summary>
        /// Event ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Event title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Is this event archived?
        /// </summary>
        public bool IsArchived { get; set; }

        public int EntryId { get; set; }

        public int CityId { get; set; }

        public string CityName { get; set; }

        public int Price { get; set; }

        public int FavoritesCount { get; set; }

        public bool IsFavorited { get; set; }

        public Company Company { get; set; }

        public int Interested { get; set; }

        #endregion
    }
}
