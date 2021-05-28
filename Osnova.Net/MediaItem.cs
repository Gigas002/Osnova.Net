using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net
{
    public class MediaItem
    {
        #region Properties

        /// <summary>
        /// Media item's title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Media item's author
        /// </summary>
        [JsonPropertyName("author")]
        public string Author { get; set; }

        /// <summary>
        /// Media items' content
        /// </summary>
        [JsonPropertyName("image")]
        public ImageBlock Image { get; set; }

        #endregion

        #region Constructors

        public MediaItem() { }

        public MediaItem(ImageBlock imageBlock, string title = null, string author = null) : this()
        {
            (Image, Title, Author) = (imageBlock, title, author);
        }

        #endregion
    }
}
