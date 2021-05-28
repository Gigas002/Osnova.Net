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
        /// Notification date in Rfc2822 format
        /// </summary>
        public DateTimeOffset DateRfc { get; set; }

        public IEnumerable<User> Users { get; set; }

        /// <summary>
        /// Notification text
        /// </summary>
        public string Text { get; set; }

        public string CommentText { get; set; }

        public Uri Url { get; set; }

        /// <summary>
        /// Название иконки, которая подставляется вместо аватарки.
        /// </summary>
        public NotificationIcon Icon { get; set; }

        #endregion
    }
}
