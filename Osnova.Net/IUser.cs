using System;
using System.Collections.Generic;
using Osnova.Net.Blocks;

namespace Osnova.Net
{
    /// <summary>
    /// Also known as "Author" and "User"
    /// </summary>
    public interface IUser
    {
        public int Id { get; set; }

        public DateTimeOffset Created { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Name { get; set; }

        public int Gender { get; set; } // TODO: enum

        public Uri Url { get; set; }

        /// <summary>
        /// Profile avatar
        /// </summary>
        public Uri AvatarUrl { get; set; }

        public int Karma { get; set; }

        /// <summary>
        /// List of social accounts
        /// </summary>
        public IEnumerable<SocialAccount> SocialAccounts { get; set; }

        public int Type { get; set; } // TODO: enum

        public ImageBlock Avatar { get; set; }

        public bool IsOnline { get; set; }

        public bool IsVerified { get; set; }

        public bool IsSubscribed { get; set; }

        public string OnlineStatusText { get; set; }
    }
}
