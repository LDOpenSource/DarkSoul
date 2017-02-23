using DarkSoul.Core.Injection;
using DarkSoul.Core.Interfaces;
using DarkSoul.Network.Extension;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace DarkSoul.Network.Protocol.Message
{
    public class MessageReceiver : Singleton<MessageReceiver>
    {
        public static readonly ConcurrentDictionary<ushort, Func<NetworkMessage>> _messages = new ConcurrentDictionary<ushort, Func<NetworkMessage>>();

        /// <summary>
        /// Get the actual .dll and read all messages, save it on a Dictionary to get and execute later
        /// </summary>
        public void Build()
        {
            var networkMessages =
                from type in typeof(MessageReceiver).GetTypeInfo().Assembly.GetTypes()
                where type.GetTypeInfo().IsSubclassOf(typeof(NetworkMessage)) && !type.GetTypeInfo().IsAbstract
                select type;

            foreach (var message in networkMessages)
            {
                var id = message.GetProperty("Id");
                if(id != null)
                {
                    var messageId = (ushort)id.GetValue(Activator.CreateInstance(message));
                    var ctor = message.GetConstructor(Type.EmptyTypes);
                    _messages.TryAdd(messageId, ctor.CreateDelegate<Func<NetworkMessage>>());
                }
            }
        }

        /// <summary>
        /// Return the message already parsed from network data
        /// </summary>
        /// <param name="id">Network Message Id</param>
        /// <param name="reader">Network reader</param>
        /// <returns></returns>
        public NetworkMessage BuildMessage(ushort id, IReader reader)
        {
            if (!_messages.ContainsKey(id))
                throw new Exception($"Message with ID : {id} doesn't exist");

            var message = _messages[id]();

            if (message == null)
                throw new Exception($"Constructors[{id}] (delegate {_messages[id]}) does not exist");

            message.Unpack(reader);
            return message;
        }
    }
}
