using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Comments;
using Osnova.Net.Enums;

namespace Osnova.Net.Popular
{
    /// <summary>
    /// Popular comments
    /// </summary>
    public class PopularComments : PopularBase // TODO: consider rewriting as generic class with custom converter
    {
        #region Properties

        /// <summary>
        /// Collection of popular comments
        /// </summary>
        [JsonPropertyName("items")]
        public IEnumerable<Comment> Items { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates new empty <see cref="PopularComments"/> object
        /// </summary>
        public PopularComments() : base(ContentType.Comment) { }

        /// <summary>
        /// Creates new <see cref="PopularComments"/> object with items
        /// </summary>
        /// <param name="items">Collection of popular comments</param>
        public PopularComments(IEnumerable<Comment> items) : this() => Items = items;

        #endregion
    }
}
