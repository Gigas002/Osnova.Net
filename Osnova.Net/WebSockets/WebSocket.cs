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

        [JsonPropertyName("type")]
        public string Type { get; set; } // TODO: enum?

        [JsonPropertyName("content_id")]
        public int EntryId { get; set; } // TODO: fix naming

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("state")]
        public int State { get; set; } // TODO: enum?

        [JsonPropertyName("user_hash")]
        public string UserHash { get; set; }

        #endregion

        #region Methods

        public static async Task QuickExampleAsync()
        {
            await using WebSocketClient client = new WebSocketClient();

            await client.ConnectAsync(new Uri("wss://ws.dtf.ru/chan/api:comments-727850")).ConfigureAwait(false);

            // After this, you can read responses in WebSocketClient.ResponseReceived until client isn't dead
        }

        #endregion
    }
}
