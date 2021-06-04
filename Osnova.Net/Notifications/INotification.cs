using System;
using System.Collections.Generic;
using Osnova.Net.Enums;
using Osnova.Net.Users;

namespace Osnova.Net.Notifications
{
    /// <summary>
    /// Refers to Notification spec
    /// </summary>
    public interface INotification
    {
        #region Properties

        /// <summary>
        /// Notification ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Notification type
        /// </summary>
        public NotificationType Type { get; set; }

        /// <summary>
        /// Notification date
        /// </summary>
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Notification date in RFC2822 format
        /// </summary>
        public DateTimeOffset DateRfc { get; set; }

        /// <summary>
        /// Collection of <see cref="User"/>s
        /// </summary>
        public IEnumerable<User> Users { get; set; }

        /// <summary>
        /// Notification text
        /// </summary>
        public string Text { get; set; }

        public string CommentText { get; set; }

        public Uri Url { get; set; }

        /// <summary>
        /// Notification's icon
        /// </summary>
        public NotificationIcon Icon { get; set; }

        #endregion
    }
}
