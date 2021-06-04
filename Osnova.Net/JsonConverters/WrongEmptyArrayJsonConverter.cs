using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts value, that sometimes (by mistakes) can be empty array in json
    /// <para/>
    /// <remarks>Returns <see langword="null"/>, if couldn't convert an object</remarks>
    /// </summary>
    /// <typeparam name="T">Any <see langword="class"/></typeparam>
    public class WrongEmptyArrayJsonConverter<T> : JsonConverter<T> where T : class
    {
        /// <inheritdoc />
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                {
                    return JsonSerializer.Deserialize<T>(ref reader, options);
                }
                default:
                {
                    reader.TrySkip();

                    return null;
                }
            }
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }
}
