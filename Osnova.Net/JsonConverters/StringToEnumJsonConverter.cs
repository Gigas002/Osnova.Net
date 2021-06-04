using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts any case-insensitive <see cref="Enum"/> to/from <see cref="string"/>
    /// </summary>
    /// <typeparam name="T"><see cref="Enum"/></typeparam>
    public class StringToEnumJsonConverter<T> : JsonConverter<T> where T : Enum
    {
        /// <inheritdoc />
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return (T)Enum.Parse(typeof(T), reader.GetString(), true);
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString().ToLowerInvariant());
        }
    }
}
