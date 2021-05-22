using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.Blocks
{
    // TODO: user or subsite?
    public class UserBlock : Block
    {
        #region Properties

        [JsonPropertyName("data")]
        public User Data { get; set; }

        #endregion

        #region Constructors

        public UserBlock() : base(BlockType.User) { }

        public UserBlock(User data) : this() => Data = data;

        #endregion
    }
}