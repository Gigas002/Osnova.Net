namespace Osnova.Net.Filters
{
    /// <summary>
    /// Refers to EventFilter spec
    /// </summary>
    public interface IEventFilter
    {
        #region Properties

        public int Id { get; set; }

        public string Title { get; set; }

        #endregion
    }
}
