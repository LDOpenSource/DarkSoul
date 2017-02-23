using DarkSoul.Network.Attribute;
using DarkSoul.Network.Injection;
using DarkSoul.Network.Reflection;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DarkSoul.Network.Protocol
{
    public class MessageHandler : Singleton<MessageHandler>
    {
        public delegate IEnumerable<NetworkMessage> CallHandler(Stream stream, NetworkMessage message);

        public static readonly ConcurrentDictionary<ushort, DynamicMethodDelegate> _handlers 
            = new ConcurrentDictionary<ushort, DynamicMethodDelegate>();
        public void Initilize(Assembly assembly)
        {
            var methods = assembly.GetTypes()
                      .SelectMany(t => t.GetMethods(BindingFlags.Public | BindingFlags.Static))
                      .Where(m => m.GetCustomAttributes(typeof(HandleAttribute), false).Count() > 0)
                      .ToArray();

            foreach (var method in methods)
            {
                var attribute = method.GetCustomAttribute(typeof(HandleAttribute)) as HandleAttribute;
                _handlers.TryAdd(attribute.Id, DynamicDelegateStaticFactory.CreateMethodCaller(method));
            }
        }
        /// <summary>
        /// Dispatch message and return IEnumerable of messages to send
        /// </summary>
        /// <param name="id"></param>
        /// <param name="client"></param>
        public IEnumerable<NetworkMessage> Process(NetworkMessage message, Stream client)
        {
            if(_handlers.TryGetValue(message.Id, out var value))            
                return (IEnumerable<NetworkMessage>)_handlers[message.Id].Invoke(null, client, message);
            throw new Exception($"Message with ID : {message.Id} don't have handler");
        }
    }
}
