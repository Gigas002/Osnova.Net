using System;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Osnova.Net.WebSockets
{
    /// <summary>
    /// Refers to Websocket spec
    /// </summary>
    public class WebSocket
    {
        #region Properties

        /// <summary>
        /// Websocket type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } // TODO: enum?

        /// <summary>
        /// Content id
        /// <para/>
        /// <remarks>Refers to "content_id" property in json</remarks>
        /// </summary>
        [JsonPropertyName("content_id")]
        public int EntryId { get; set; } // TODO: fix naming

        /// <summary>
        /// Count
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// State
        /// </summary>
        [JsonPropertyName("state")]
        public int State { get; set; } // TODO: enum?

        /// <summary>
        /// User hash
        /// </summary>
        [JsonPropertyName("user_hash")]
        public string UserHash { get; set; }

        #endregion

        #region Methods

        internal static async Task QuickExampleAsync()
        {
            await using WebSocketClient client = new WebSocketClient();

            await client.ConnectAsync(new Uri("wss://ws.dtf.ru/chan/api:comments-727850")).ConfigureAwait(false);

            // After this, you can read responses in WebSocketClient.ResponseReceived until client isn't dead
        }

        #endregion
    }
}
