using System;
using System.Collections.Generic;
using Osnova.Net.Blocks;
using Osnova.Net.Comments;
using Osnova.Net.Enums;
using Osnova.Net.Users;

namespace Osnova.Net.Entries
{
    /// <summary>
    /// Refers to specification of Entry on official API docs
    /// </summary>
    public interface IEntry
    {
        #region Properties

        /// <summary>
        /// Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Link to open entry
        /// </summary>
        public Uri WebviewUrl { get; set; }

        /// <summary>
        /// Contains ready html and version
        /// </summary>
        public EntryLayout EntryLayout { get; set; }

        /// <summary>
        /// Entry's creation date
        /// <para/>
        /// <remarks>Converts from/to <see cref="long"/></remarks>
        /// </summary>
        public DateTimeOffset DateCreated { get; set; }

        /// <summary>
        /// Entry's creation date
        /// <para/>
        /// <remarks>Converts from/to RFC2822 string</remarks>
        /// </summary>
        public DateTimeOffset DateCreatedRfc { get; set; }

        /// <summary>
        /// Entry's last modification date
        /// <para/>
        /// <remarks>Converts from/to <see cref="long"/></remarks>
        /// </summary>
        public DateTimeOffset LastModificationDate { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        public User Author { get; set; }

        /// <summary>
        /// Content type
        /// </summary>
        public ContentType Type { get; set; }

        /// <summary>
        /// Entry's intro
        /// </summary>
        public string Intro { get; set; }

        public Cover Cover { get; set; }

        /// <summary>
        /// Entry's intro in feed
        /// </summary>
        public string IntroInFeed { get; set; }

        /// <summary>
        /// Collection of similar entries
        /// </summary>
        public IEnumerable<Entry> Similar { get; set; }

        /// <summary>
        /// Count of views of this entry
        /// </summary>
        public int ViewsCount { get; set; }

        /// <summary>
        /// Likes of this entry
        /// </summary>
        public Likes Likes { get; set; }

        /// <summary>
        /// Preview collection of comments of this entry
        /// </summary>
        public IEnumerable<Comment> CommentsPreview { get; set; }

        /// <summary>
        /// Count of comments of this entry
        /// </summary>
        public int CommentsCount { get; set; }

        /// <summary>
        /// Count of times this entry was added to favorites
        /// </summary>
        public int FavoritesCount { get; set; }

        /// <summary>
        /// Current user favorited this entry?
        /// </summary>
        public bool IsFavorited { get; set; }

        /// <summary>
        /// Are likes enabled on this entry?
        /// </summary>
        public bool IsEnabledLikes { get; set; }

        /// <summary>
        /// Are comments enabled on this entry?
        /// </summary>
        public bool IsEnabledComments { get; set; }

        /// <summary>
        /// Is this editorial entry?
        /// </summary>
        public bool IsEditorial { get; set; }

        /// <summary>
        /// Is this entry pinned?
        /// </summary>
        public bool IsPinned { get; set; }

        /// <summary>
        /// Url to voiced version of entry if it exists
        /// </summary>
        public Uri AudioUrl { get; set; }

        public IEnumerable<Badge> Badges { get; set; }

        /// <summary>
        /// Collection of commentators avatars urls for preview
        /// </summary>
        public IEnumerable<Uri> CommentatorsAvatars { get; set; }

        /// <summary>
        /// Subsite, where this entry was created
        /// </summary>
        public User Subsite { get; set; }

        public double Hotness { get; set; }

        /// <summary>
        /// Is current user subscribed to comments?
        /// </summary>
        public bool SubscribedToComments { get; set; }

        /// <summary>
        /// Collection of blocks in entry
        /// </summary>
        public IEnumerable<Block> Blocks { get; set; }

        /// <summary>
        /// Can current user edit this post?
        /// </summary>
        public bool CanEdit { get; set; }

        /// <summary>
        /// Date, when this entry was added to favorites
        /// <para/>
        /// <remarks>Converts from/to <see cref="long"/></remarks>
        /// </summary>
        public DateTimeOffset DateFavorite { get; set; }

        /// <summary>
        /// Is this repost?
        /// </summary>
        public bool IsRepost { get; set; }

        /// <summary>
        /// Is this promoted entry?
        /// </summary>
        public bool IsPromoted { get; set; }

        public Repost Repost { get; set; }

        public CommentsSeenCount CommentsSeenCount { get; set; }

        public AdditionalControls AdditionalControls { get; set; }

        public bool IsShowThanks { get; set; }

        /// <summary>
        /// Is this entry still updating?
        /// </summary>
        public bool IsStillUpdating { get; set; }

        public bool IsFilledByEditors { get; set; }

        public User CoAuthor { get; set; }

        #endregion
    }
}
