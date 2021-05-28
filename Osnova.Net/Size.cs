using System.Text.Json.Serialization;

namespace Osnova.Net
{
    /// <summary>
    /// Sizes of media content
    /// </summary>
    public class Size
    {
        /// <summary>
        /// Width
        /// </summary>
        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        [JsonPropertyName("height")]
        public int Height { get; set; }

        /// <summary>
        /// Ratio
        /// </summary>
        [JsonPropertyName("ratio")]
        public double Ratio { get; set; }
    }
}
