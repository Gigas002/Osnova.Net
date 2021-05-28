using System.Text.Json.Serialization;
using Osnova.Net.Enums;
using Osnova.Net.Users;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// User inside of block
    /// </summary>
    public class UserBlock : Block
    {
        #region Properties

        /// <summary>
        /// Actual data of the block
        /// </summary>
        [JsonPropertyName("data")]
        public User Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create default <see cref="UserBlock"/>
        /// </summary>
        public UserBlock() : base(BlockType.User) { }

        /// <summary>
        /// Create <see cref="UserBlock"/> with <see cref="User"/>
        /// </summary>
        /// <param name="data">Data to add</param>
        public UserBlock(User data) : this() => Data = data;

        #endregion
    }
}