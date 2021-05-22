using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(ListTypeJsonConverter))]
    public enum ListType
    {
        UnorderedList,
        OrderedList
    }
}
