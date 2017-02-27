using System;
using Newtonsoft.Json;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Net.Sockets;
using System.ServiceModel.Channels;
using DarkSoul.Network.Extension;
using System.Reactive.Disposables;
using Newtonsoft.Json.Linq;
using DarkSoul.Network.Interface;

namespace DarkSoul.Network.IPC
{
    /// <summary>
    /// A implementation based on signalr HubConnection from Microsoft
    /// </summary>
    public class SoulConnection : IConnection
    {
        #region Fields

        internal readonly Dictionary<string, Action<MsgResult>> _callbacks = new Dictionary<string, Action<MsgResult>>();
        private int _callbackId;
        private NetworkStream ClientStream;

        #endregion

        public SoulConnection(string ip, int port)
        {
            Cancel = new CancellationTokenSource();
            Init(ip, port);
        }

        #region Props

        public JsonSerializer JsonSerializer { get; internal set; }

        public CancellationTokenSource Cancel { get; private set; }

        public Socket ClientSocket { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        /// Return a SoulProxy to make method calls
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public SoulProxy CreateSoulProxy(string name = "default") //add functionality later for name
        {
            return new SoulProxy(this, name);
        }

        public string RegisterCallback(Action<MsgResult> callback)
        {
            lock (_callbacks)
            {
                string id = _callbackId.ToString(CultureInfo.InvariantCulture);
                _callbacks[id] = callback;
                _callbackId++;
                return id;
            }
        }

        internal void RemoveCallback(string callbackId)
        {
            lock (_callbacks)
            {
                _callbacks.Remove(callbackId);
            }
        }

        private void Init(string ip, int port)
        {
            var bufferManager = BufferManager.CreateBufferManager(2 << 16, 2 << 8);

            new IPEndPoint(IPAddress.Parse(ip), port).ToConnectObservable()
                .Subscribe(socket =>
                {
                    var frameClient = socket.ToFrameClientSubject(bufferManager, Cancel.Token, out ClientStream);

                    var observerDisposable =
                        frameClient
                            .ObserveOn(TaskPoolScheduler.Default)
                            .Subscribe(
                                disposableBuffer =>
                                {
                                    var response = Encoding.UTF8.GetString(disposableBuffer.Value.Array, 0, disposableBuffer.Value.Count);
                                    var result = this.JsonDeserializeObject<JObject>(response);

                                    Console.WriteLine("Read: " + response);
                                    if (result["I"] != null)                                    
                                        OnReceived(result);                                    
                                    else                                    
                                        throw new Exception("I property it's null");
                                    
                                    disposableBuffer.Dispose();
                                },
                                error => Console.WriteLine("Error: " + error.Message),
                                () => Console.WriteLine("OnCompleted: SoulConnection"));

                    observerDisposable.Dispose();

                    Cancel.Cancel();
                },
                error =>
                {
                    Console.WriteLine("Falied to connect: " + error.Message);
                });

            Cancel.Token.WaitHandle.WaitOne();
        }

        public Task Send(object value)
        {
            if (ClientStream == null)
            {
                throw new ArgumentNullException("ClientSteam");
            }

            if (!ClientStream.CanWrite)
            {
                var ex = new InvalidOperationException("Client Stream can write");
                var tcs = new TaskCompletionSource<object>();
                tcs.SetException(ex);
                return tcs.Task;
            }
            //send over socket
            var writeBuffer = Encoding.UTF8.GetBytes(this.JsonSerializeObject(value));
            var disposableBuffer = DisposableValue.Create(new ArraySegment<byte>(writeBuffer), Disposable.Empty);
            var headerBuffer = BitConverter.GetBytes(disposableBuffer.Value.Count);

            return Task.WhenAll(new Task[]
                    {
                        ClientStream.WriteAsync(headerBuffer, 0, headerBuffer.Length, Cancel.Token),
                        ClientStream.WriteAsync(disposableBuffer.Value.Array, 0, disposableBuffer.Value.Count, Cancel.Token),
                        ClientStream.FlushAsync(Cancel.Token)
                    });
        }

        private void OnReceived(JObject message)
        {
            if (message["I"] != null)
            {
                var result = message.ToObject<MsgResult>(JsonSerializer);
                Action<MsgResult> callback;

                lock (_callbacks)
                {
                    if (_callbacks.TryGetValue(result.Id, out callback))                    
                        _callbacks.Remove(result.Id);                    
                    else                    
                        Console.WriteLine("Callback with id " + result.Id + " not found!");                    
                }

                callback?.Invoke(result);
            }
        }

        #endregion
    }
}