using System.Text.Json.Serialization;

namespace Osnova.Net.Users
{
    /// <summary>
    /// Additional actions for <see cref="AdvancedAccess"/>
    /// </summary>
    public class AdvancedAccessActions
    {
        #region Properties
        
        /// <summary>
        /// Can read comments?
        /// <para/>
        /// <remarks>Refers to "read_comments" property in json</remarks>
        /// </summary>
        [JsonPropertyName("read_comments")]
        public bool CanReadComments { get; set; }

        /// <summary>
        /// Can write comments?
        /// <para/>
        /// <remarks>Refers to "write_comments" property in json</remarks>
        /// </summary>
        [JsonPropertyName("write_comments")]
        public bool CanWriteComments { get; set; }
        
        #endregion
    }
}