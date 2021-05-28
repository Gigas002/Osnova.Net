using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    public class StringToEnumJsonConverter<T> : JsonConverter<T> where T : Enum
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return (T)Enum.Parse(typeof(T), reader.GetString(), true);
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString().ToLowerInvariant());
        }
    }
}
