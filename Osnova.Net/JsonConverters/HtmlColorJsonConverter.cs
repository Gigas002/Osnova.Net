using System;
using System.Drawing;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts #argb"x6-<see cref="Color"/> to/from <see cref="string"/>
    /// <para/>
    /// <remarks>
    /// Comparing with <see cref="ColorJsonConverter"/>, here string includes "#" symbol
    /// </remarks>
    /// </summary>
    public class HtmlColorJsonConverter : JsonConverter<Color>
    {
        /// <inheritdoc />
        public override Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string hex = reader.GetString()?.Replace("#", string.Empty, StringComparison.InvariantCulture);

            return string.IsNullOrWhiteSpace(hex) ? default
                       : Color.FromArgb(int.Parse(hex, NumberStyles.HexNumber, CultureInfo.InvariantCulture));
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, Color value, JsonSerializerOptions options)
        {
            int argb = value.ToArgb();

            writer.WriteStringValue($"#{argb:x6}");
        }
    }
}
