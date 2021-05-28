using System;
using System.Collections.Generic;
using Osnova.Net.Blocks;
using Osnova.Net.Entries;
using Osnova.Net.Enums;
using Osnova.Net.Users;

namespace Osnova.Net.Comments
{
    /// <summary>
    /// Refers to "Comment" specification
    /// </summary>
    public interface IComment
    {
        #region Properties

        /// <summary>
        /// Comment's ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date, when this comment was created
        /// </summary>
        public DateTimeOffset DateCreated { get; set; }

        /// <summary>
        /// Date, when this comment was created
        /// </summary>
        public DateTimeOffset DateCreatedRfc { get; set; }

        /// <summary>
        /// Comment's author
        /// </summary>
        public User Author { get; set; }

        /// <summary>
        /// Full comment's text with HTML
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Full comment's text with markdown
        /// </summary>
        public string MarkdownText { get; set; }

        /// <summary>
        /// Media files, attached to comment.
        /// Not a copy of <see cref="Attachments"/>
        /// </summary>
        public IEnumerable<CommentMedia> Media { get; set; }

        /// <summary>
        /// Likes of this comment
        /// </summary>
        public Likes Likes { get; set; }

        /// <summary>
        /// To which entry this comment is bound?
        /// </summary>
        public Entry Entry { get; set; }

        /// <summary>
        /// ID of user, if comment was a reply
        /// </summary>
        public int ReplyToId { get; set; }

        /// <summary>
        /// Is current logged user favorited this comment?
        /// </summary>
        public bool IsFavorited { get; set; }

        /// <summary>
        /// Is this comment pinned?
        /// </summary>
        public bool IsPinned { get; set; }

        /// <summary>
        /// Was this comment edited?
        /// </summary>
        public bool IsEdited { get; set; }

        /// <summary>
        /// Level of depth in thread
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// From which OS this comment was created?
        /// </summary>
        public SourceOs SourceOs { get; set; }

        /// <summary>
        /// Exists if there are a lot a hidden comments in reply to this
        /// </summary>
        public CommentsLoadMore LoadMore { get; set; }

        /// <summary>
        /// Collection of additional blocks (images/videos/etc) for this comment
        /// <para/>
        /// <remarks>In spec it's Attach, but in reality -- <see cref="Block"/></remarks>
        /// </summary>
        public IEnumerable<Block> Attachments { get; set; }

        /// <summary>
        /// Additional controls
        /// </summary>
        public AdditionalControls AdditionalControls { get; set; }

        #endregion
    }
}
