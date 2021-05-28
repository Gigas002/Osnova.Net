using System;
using System.Drawing;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Special button
    /// <para/>
    /// <remarks>Editoral block</remarks>
    /// </summary>
    public class SpecialButtonBlockData
    {
        #region Properties

        /// <summary>
        /// Button text
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Text color
        /// </summary>
        [JsonConverter(typeof(HtmlColorJsonConverter))]
        [JsonPropertyName("textColor")]
        public Color TextColor { get; set; }

        /// <summary>
        /// Background color
        /// </summary>
        [JsonConverter(typeof(HtmlColorJsonConverter))]
        [JsonPropertyName("backgroundColor")]
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        #endregion
    }
}
