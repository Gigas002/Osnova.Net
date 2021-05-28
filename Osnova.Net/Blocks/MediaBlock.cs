using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Media block with images/gifs/etc
    /// </summary>
    public class MediaBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public MediaBlockData Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="MediaBlock"/>
        /// </summary>
        public MediaBlock() : base(BlockType.Media) { }

        /// <summary>
        /// Create <see cref="MediaBlock"/> with <see cref="MediaBlockData"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public MediaBlock(MediaBlockData data) : this() => Data = data;

        #endregion

        /// <summary>
        /// Get all <see cref="ImageBlockData"/>s inside of this <see cref="MediaBlock"/>
        /// </summary>
        /// <returns>Collection of <see cref="ImageBlockData"/></returns>
        public IEnumerable<ImageBlockData> GetImageDatas()
        {
            return Data?.Items?.Select(mediaItem => mediaItem.Image.Data);
        }
    }
}