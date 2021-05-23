using System;
using System.Collections.Generic;
using Osnova.Net.Blocks;

namespace Osnova.Net
{
    public interface ISubsite : IUser
    {
        public string Description { get; set; }

        /// <summary>
        /// Profile cover
        /// <para/>
        /// <remarks>Docs says it's <see cref="Net.Cover"/>,
        /// but actual query returns <see cref="ImageBlock"/></remarks>
        /// </summary>
        public ImageBlock Cover { get; set; }

        public bool IsUnsubscribable { get; set; }

        public int SubscribersCount { get; set; }

        public int CommentsCount { get; set; }

        public int EntriesCount { get; set; }

        public int VacanciesCount { get; set; }

        public DateTimeOffset CreatedRFC { get; set; }

        /// <summary>
        /// Личный топик пользователя в Firebase Messaging
        /// </summary>
        public string PushTopic { get; set; }

        /// <summary>
        /// Список разрешений
        /// </summary>
        public AdvancedAccess AdvancedAccess { get; set; }

        public Counters Counters { get; set; }

        /// <summary>
        /// Хеш ID пользователя. Используется для сравнения данных, где ID захеширован
        /// </summary>
        public string UserHash { get; set; }

        public Contacts Contacts { get; set; }

        public bool IsAvailableForMessenger { get; set; }

        public bool IsMuted { get; set; }

        public bool IsSubscribedToNewPosts { get; set; }

        public IEnumerable<SubscriberAvatar> SubscribersAvatars { get; set; }

        public bool IsPlus { get; set; }

        public Uri HeadCover { get; set; }

        public bool IsEnableWriting { get; set; }

        public string Rules { get; set; }

        public int EventsCount { get; set; }

        public CommentEditor CommentEditor { get; set; }
    }
}
