using System;
using System.Threading.Tasks;

namespace Osnova.Net.WebSockets
{
    public static class WebSockets
    {
        public static async Task QuickExampleAsync()
        {
            await using WebSocketClient client = new WebSocketClient();

            await client.ConnectAsync(new Uri("wss://ws.dtf.ru/chan/api:comments-727850")).ConfigureAwait(false);

            // After this, you can read responses in WebSocketClient.ResponseReceived until client isn't dead
        }
    }
}
