using System;

namespace Osnova.Net.Companies
{
    /// <summary>
    /// Refers to Company spec
    /// </summary>
    public interface ICompany
    {
        #region Properties

        /// <summary>
        /// Company's ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Company's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Company's logo's URL
        /// </summary>
        public Uri Logo { get; set; } // TODO: rename to avatar? check this

        /// <summary>
        /// Company's URL
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// Is verified company
        /// </summary>
        public bool IsVerified { get; set; }

        #endregion
    }
}
