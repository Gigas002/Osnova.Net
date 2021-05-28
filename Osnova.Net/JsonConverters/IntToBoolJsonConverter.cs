using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    public class IntToBoolJsonConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Convert.ToBoolean(reader.GetInt32());
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(Convert.ToInt32(value));
        }
    }
}
