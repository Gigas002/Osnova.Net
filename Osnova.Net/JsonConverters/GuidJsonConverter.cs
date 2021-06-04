using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts <see cref="Guid"/> to/from <see cref="string"/>
    /// <para/>
    /// <remarks>If it's not correct -- sets to default value</remarks>
    /// </summary>
    public class GuidJsonConverter : JsonConverter<Guid>
    {
        /// <inheritdoc />
        public override Guid Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Sometimes it's url/string... ask ochoba's programmers WHY
            reader.TryGetGuid(out Guid guid);

            return guid;
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, Guid value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }
}
