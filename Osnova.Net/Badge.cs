using System.Drawing;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;
using Osnova.Net.JsonConverters;

namespace Osnova.Net
{
    public class Badge
    {
        [JsonPropertyName("type")]
        public Alignment Alignment { get; set; }

        /// <summary>
        /// Badge text value
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Badge color
        /// </summary>
        [JsonConverter(typeof(HtmlColorJsonConverter))]
        [JsonPropertyName("color")]
        public Color Color { get; set; }

        /// <summary>
        /// Background color
        /// </summary>
        [JsonConverter(typeof(HtmlColorJsonConverter))]
        [JsonPropertyName("background")]
        public Color Background { get; set; }

        /// <summary>
        /// Border color
        /// </summary>
        [JsonConverter(typeof(HtmlColorJsonConverter))]
        [JsonPropertyName("border")]
        public Color Border { get; set; }
    }
}
