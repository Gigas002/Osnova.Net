using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class OsnovaResponse<T>
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("result")]
        public T Result { get; set; }
    }
}
