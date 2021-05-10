using System;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Osnova.Net
{
    /// <summary>
    /// Modified code from here: https://stackoverflow.com/questions/30523478/connecting-to-websocket-using-c-sharp-i-can-connect-using-javascript-but-c-sha/58285551
    /// Test websockets here: https://www.piesocket.com/websocket-tester
    /// </summary>
    public class WebSocketClient : IDisposable, IAsyncDisposable
    {
        public const int ReceiveBufferSize = 8192;

        private ClientWebSocket WebSocket { get; set; }

        private CancellationTokenSource WebSocketCancellactionToken { get; set; }

        public bool IsDisposed { get; protected set; }

        #region Dispose

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <inheritdoc cref="Dispose()"/>
        /// <param name="disposing">Dispose static fields?</param>
        protected virtual void Dispose(bool disposing)
        {
            if (IsDisposed) return;

            if (disposing)
            {
                // Dispose static things here
            }

            DisconnectAsync().Wait();
        }

        /// <inheritdoc />
        public ValueTask DisposeAsync()
        {
#pragma warning disable CA1031 // Do not catch general exception types

            try
            {
                Dispose(true);
                GC.SuppressFinalize(this);

                return ValueTask.CompletedTask;
            }
            catch (Exception exception)
            {
                return ValueTask.FromException(exception);
            }

#pragma warning restore CA1031 // Do not catch general exception types
        }

        #endregion

        ~WebSocketClient() => Dispose(false);

        public async Task ConnectAsync(Uri uri)
        {
            if (WebSocket?.State == WebSocketState.Open) return;

            WebSocket?.Dispose();
            WebSocketCancellactionToken?.Dispose();

            WebSocket = new ClientWebSocket();
            WebSocketCancellactionToken = new CancellationTokenSource();

            await WebSocket.ConnectAsync(uri, WebSocketCancellactionToken.Token).ConfigureAwait(false);

            await Task.Factory.StartNew(ReceiveLoop, WebSocketCancellactionToken.Token, TaskCreationOptions.LongRunning,
                                        TaskScheduler.Default).ConfigureAwait(false);
        }

        public async Task DisconnectAsync()
        {
            if (WebSocket is null) return;

            if (WebSocket.State == WebSocketState.Open)
            {
                WebSocketCancellactionToken.CancelAfter(TimeSpan.FromSeconds(2));
                await WebSocket.CloseOutputAsync(WebSocketCloseStatus.Empty, "", CancellationToken.None).ConfigureAwait(false);
                await WebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None).ConfigureAwait(false);
            }

            WebSocket.Dispose();
            WebSocket = null;
            WebSocketCancellactionToken.Dispose();
            WebSocketCancellactionToken = null;
        }

        private async Task ReceiveLoop()
        {
            CancellationToken loopToken = WebSocketCancellactionToken.Token;
            MemoryStream outputStream = null;
            var buffer = new byte[ReceiveBufferSize];

            try
            {
                while (!loopToken.IsCancellationRequested)
                {
                    outputStream = new MemoryStream(ReceiveBufferSize);
                    WebSocketReceiveResult receiveResult;

                    do
                    {
                        receiveResult = await WebSocket.ReceiveAsync(buffer, WebSocketCancellactionToken.Token).ConfigureAwait(false);

                        if (receiveResult.MessageType != WebSocketMessageType.Close)
                        {
                            await outputStream.WriteAsync(buffer, loopToken).ConfigureAwait(false);
                        }
                    }
                    while (!receiveResult.EndOfMessage);

                    if (receiveResult.MessageType == WebSocketMessageType.Close) break;

                    outputStream.Position = 0;
                    await ResponseReceived(outputStream).ConfigureAwait(false);
                }
            }
            catch (TaskCanceledException) { }
            finally
            {
                if (outputStream != null) await outputStream.DisposeAsync().ConfigureAwait(false);
            }
        }

        private static Task<string> ResponseReceived(Stream inputStream)
        {
            // TODO: use action/func for response reading?

            using StreamReader streamReader = new(inputStream, Encoding.UTF8);

            return streamReader.ReadToEndAsync();
        }
    }
}
