using DarkSoul.Core.Instance;
using DarkSoul.Network.Extension;
using DarkSoul.Network.Protocol.Types;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace DarkSoul.Network.Protocol
{
    public class ProtocolTypeManager : Singleton<ProtocolTypeManager>
    {
        private static readonly ConcurrentDictionary<ushort, Func<object>> _types =
            new ConcurrentDictionary<ushort, Func<object>>();

        public void Initialize()
        {
            var networkTypes =
                from type in typeof(GameServerInformations).GetTypeInfo().Assembly.GetTypes()
                where !type.GetTypeInfo().IsSubclassOf(typeof(NetworkMessage))
                select type;
            foreach (var type in networkTypes)
            {
                var field = type.GetField("TypeId");
                if (field != null)
                {
                    var key = (ushort)field.GetValue(type);
                    var constructor = type.GetConstructor(Type.EmptyTypes);
                    if (constructor == null)                    
                        throw new Exception(string.Format("'{0}' doesn't implemented a parameterless constructor", type));                    
                    _types.TryAdd(key, constructor.CreateDelegate<Func<object>>());
                }
            }
        }

        public static T GetInstance<T>(ushort id) where T : class
        {
            if (_types.TryGetValue(id, out var value))
                return value() as T;
            throw new Exception($"Type <id:{id}> doesn't exist");
        }
    }
}
