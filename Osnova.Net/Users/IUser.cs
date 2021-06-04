using System;
using System.Collections.Generic;

namespace Osnova.Net.Users
{
    /// <summary>
    /// Also known as "Author" and "User"
    /// <para/>
    /// <remarks>Refers to specification of Author on official API docs</remarks>
    /// </summary>
    public interface IUser
    {
        #region Properties
        
        /// <summary>
        /// Profile's ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date, when this profile was created
        /// </summary>
        public DateTimeOffset DateCreated { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Full name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        public int Gender { get; set; } // TODO: enum

        /// <summary>
        /// Profile's page URL
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// Profile avatar URL
        /// </summary>
        public Uri AvatarUrl { get; set; }

        /// <summary>
        /// Value of karma
        /// </summary>
        public int Karma { get; set; }

        /// <summary>
        /// Collection of social accounts, if there are any
        /// </summary>
        public IEnumerable<SocialAccount> SocialAccounts { get; set; }
        
        #endregion
    }
}
