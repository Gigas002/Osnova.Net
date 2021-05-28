using System.Text.Json.Serialization;
using Osnova.Net.Users;

namespace Osnova.Net.Entries
{
    public class Repost // TODO: rename to EntryRepost?
    {
        [JsonPropertyName("author")]
        public User Author { get; set; }
    }
}