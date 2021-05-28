using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(StringToEnumJsonConverter<Alignment>))]
    public enum Alignment
    {
        Left,
        Centered,
        Top,
        Bottom
    }
}
