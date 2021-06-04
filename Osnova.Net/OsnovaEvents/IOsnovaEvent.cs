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

        /// <summary>
        /// City ID
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Favorites count
        /// </summary>
        public int FavoritesCount { get; set; }

        /// <summary>
        /// Is this event favorited?
        /// </summary>
        public bool IsFavorited { get; set; }

        /// <summary>
        /// Company
        /// </summary>
        public Company Company { get; set; }

        public int Interested { get; set; }

        #endregion
    }
}
