using System;
using System.Drawing;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.BlockDatas
{
    public class SpecialButtonBlockData
    {
        #region Properties

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonConverter(typeof(HtmlColorJsonConverter))]
        [JsonPropertyName("textColor")]
        public Color TextColor { get; set; }

        [JsonConverter(typeof(HtmlColorJsonConverter))]
        [JsonPropertyName("backgroundColor")]
        public Color BackgroundColor { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        #endregion
    }
}
