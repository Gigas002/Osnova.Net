using System;
using Osnova.Net.Blocks;

namespace Osnova.Net.Users
{
    /// <summary>
    /// Also known as "Subsite" and, in most cases, "User"
    /// <para/>
    /// <remarks>Refers to Subsite specification</remarks>
    /// </summary>
    public interface ISubsite : IUser
    {
        #region Properties

        /// <summary>
        /// Profile type
        /// </summary>
        public int Type { get; set; } // TODO: enum

        /// <summary>
        /// Profile description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Profile cover
        /// <para/>
        /// <remarks>Docs says it's <see cref="Cover"/>,
        /// but actual query returns <see cref="ImageBlock"/></remarks>
        /// </summary>
        public ImageBlock ProfileCover { get; set; }

        /// <summary>
        /// Is current logged user subscribed to this profile?
        /// </summary>
        public bool IsSubscribed { get; set; }

        /// <summary>
        /// Is verified?
        /// </summary>
        public bool IsVerified { get; set; }

        /// <summary>
        /// Is profile insubscribable?
        /// </summary>
        public bool IsUnsubscribable { get; set; }

        /// <summary>
        /// Subscribers count
        /// </summary>
        public int SubscribersCount { get; set; }

        /// <summary>
        /// Comments count
        /// </summary>
        public int CommentsCount { get; set; }

        /// <summary>
        /// Entries count
        /// </summary>
        public int EntriesCount { get; set; }

        /// <summary>
        /// Vacancies count
        /// </summary>
        public int VacanciesCount { get; set; }

        /// <summary>
        /// Date, when this profile was created in RFC2822 format
        /// </summary>
        public DateTimeOffset DateCreatedRfc { get; set; }

        /// <summary>
        /// Push topic
        /// </summary>
        public string PushTopic { get; set; }

        /// <summary>
        /// Advanced controls
        /// </summary>
        public AdvancedAccess AdvancedAccess { get; set; }

        /// <summary>
        /// Additional profile counters
        /// </summary>
        public UserCounters Counters { get; set; }

        /// <summary>
        /// Profile's hash ID
        /// </summary>
        public string UserHash { get; set; }

        /// <summary>
        /// Profile contacts
        /// </summary>
        public UserContacts Contacts { get; set; }
        
        #endregion
    }
}
