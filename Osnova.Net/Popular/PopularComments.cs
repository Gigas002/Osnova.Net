using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Comments;
using Osnova.Net.Enums;

namespace Osnova.Net.Popular
{
    public class PopularComments : PopularBase
    {
        [JsonPropertyName("items")]
        public IEnumerable<Comment> Items { get; set; }

        #region Constructors

        public PopularComments() : base(ContentType.Comment) { }

        public PopularComments(IEnumerable<Comment> items) : this() => Items = items;

        #endregion
    }
}
