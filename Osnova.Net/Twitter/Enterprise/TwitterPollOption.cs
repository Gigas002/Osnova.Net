using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter.Enterprise
{
    /// <summary>
    /// Twitter poll's option
    /// <para/>
    /// <remarks>API version: 1.1</remarks>
    /// </summary>
    public class TwitterPollOption
    {
        #region Properties
        
        /// <summary>
        /// Position in poll
        /// </summary>
        [JsonPropertyName("position")]
        public int Position { get; set; }

        /// <summary>
        /// Text value
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
        
        #endregion
    }
}
