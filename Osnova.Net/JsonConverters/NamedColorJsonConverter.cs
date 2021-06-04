using System;
using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts named <see cref="Color"/> to/from <see cref="string"/>
    /// <para/>
    /// <remarks>
    /// String example: "blue"
    /// </remarks>
    /// </summary>
    public class NamedColorJsonConverter : JsonConverter<Color>
    {
        /// <inheritdoc />
        public override Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Color.FromName(reader.GetString());
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, Color value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString().ToLowerInvariant());
        }
    }
}
