namespace Osnova.Net.Filters
{
    /// <summary>
    /// Refers to EventFilter spec
    /// </summary>
    public interface IEventFilter
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

        #endregion
    }
}
