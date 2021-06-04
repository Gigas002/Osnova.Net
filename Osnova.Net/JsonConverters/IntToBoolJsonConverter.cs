using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts <see cref="int"/>, presented in json, to/from <see cref="bool"/>, presented in code
    /// </summary>
    public class IntToBoolJsonConverter : JsonConverter<bool>
    {
        /// <inheritdoc />
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Convert.ToBoolean(reader.GetInt32());
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(Convert.ToInt32(value));
        }
    }
}
