using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Container of media data (images, videos) in block
    /// </summary>
    public class MediaBlockData
    {
        #region Properties

        /// <summary>
        /// Collection of media items in block
        /// </summary>
        [JsonPropertyName("items")]
        public IEnumerable<MediaItem> Items { get; set; }

        /// <summary>
        /// Do you want to add background?
        /// </summary>
        [JsonPropertyName("with_background")]
        public bool WithBackground { get; set; }

        /// <summary>
        /// Do you want to add a border?
        /// </summary>
        [JsonPropertyName("with_border")]
        public bool WithBorder { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates default <see cref="MediaBlockData"/>
        /// </summary>
        public MediaBlockData() { }

        /// <summary>
        /// Creates default <see cref="MediaBlockData"/> with images in it
        /// </summary>
        /// <param name="imageBlocks">Collection of images</param>
        public MediaBlockData(IEnumerable<ImageBlock> imageBlocks)
        {
            #region Preconditions checks

            if (imageBlocks == null) throw new ArgumentNullException(nameof(imageBlocks));

            #endregion

            Items = new List<MediaItem>();

            foreach (var imageBlock in imageBlocks)
            {
                ((List<MediaItem>)Items).Add(new MediaItem(imageBlock));
            }
        }

        #endregion
    }
}
