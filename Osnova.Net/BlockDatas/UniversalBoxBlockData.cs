using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Universal block for external services's data
    /// </summary>
    public class UniversalBoxBlockData
    {
        #region Properties

        /// <summary>
        /// Service type
        /// </summary>
        [JsonPropertyName("service")]
        public ExternalServiceType Service { get; set; }

        /// <summary>
        /// Service data
        /// <para/>
        /// <remarks>Refers to "box_data" property in json</remarks>
        /// </summary>
        [JsonPropertyName("box_data")]
        public BoxData Data { get; set; }

        #endregion
    }
}
