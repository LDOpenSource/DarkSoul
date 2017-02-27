using DarkSoul.Network.Extension;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace DarkSoul.Network.IPC
{
    /// <summary>
    /// A implementation based on signalr HubProxy from Microsoft
    /// </summary>
    public class SoulProxy
    {
        private SoulConnection _connection;
        private string _soulName;
        public SoulProxy(SoulConnection connection, string name)
        {
            _connection = connection;
            _soulName = name;
        }
        public JsonSerializer JsonSerializer
        {
            get { return _connection.JsonSerializer; }
        }

        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Exceptions are flown to the caller")]
        public Task<TResult> Invoke<TResult>(string method, params object[] args)
        {
            if (method == null)
            {
                throw new ArgumentNullException("method");
            }

            if (args == null)
            {
                throw new ArgumentNullException("args");
            }

            var tokenifiedArguments = new JToken[args.Length];
            for (int i = 0; i < tokenifiedArguments.Length; i++)
            {
                tokenifiedArguments[i] = args[i] != null
                    ? JToken.FromObject(args[i], JsonSerializer)
                    : JValue.CreateNull();
            }

            var tcs = new TaskCompletionSource<TResult>();
            var callbackId = _connection.RegisterCallback(result =>
            {
                if (result != null)
                {
                    if (result.Error != null)                    
                        tcs.TrySetException(new InvalidOperationException(result.Error));
                    else
                    {
                        try
                        {
                            if (result.Result != null)                            
                                tcs.TrySetResult(result.Result.ToObject<TResult>(JsonSerializer));                            
                            else                            
                                tcs.TrySetResult(default(TResult));                            
                        }
                        catch (Exception ex)
                        {
                            // If we failed to set the result for some reason or to update
                            // state then just fail the tcs.
                            tcs.TrySetException(ex);
                        }
                    }
                }
                else
                {
                    tcs.TrySetCanceled();
                }
            });

            var soulData = new SoulInvocation
            {
                Soul = _soulName,
                Method = method,
                Args = tokenifiedArguments,
                CallbackId = callbackId
            };

            var value = _connection.JsonSerializeObject(soulData);

            _connection.Send(value).ContinueWith(task =>
            {
                if (task.IsCanceled)
                {
                    _connection.RemoveCallback(callbackId);
                    tcs.TrySetCanceled();
                }
                else if (task.IsFaulted)
                {
                    _connection.RemoveCallback(callbackId);
                    tcs.TrySetException(task.Exception);
                }
            },
            TaskContinuationOptions.NotOnRanToCompletion);

            return tcs.Task;
        }
    }
}
