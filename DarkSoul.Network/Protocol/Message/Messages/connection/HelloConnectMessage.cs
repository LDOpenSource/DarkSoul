

// Generated on 02/23/2017 16:53:16
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;

namespace DarkSoul.Network.Protocol.Messages
{
    public class HelloConnectMessage : NetworkMessage
    {
        public override ushort Id => 3;
        
        
        public string salt;
        public IEnumerable<byte> key;
        
        public HelloConnectMessage()
        {
        }
        
        public HelloConnectMessage(string salt, IEnumerable<byte> key)
        {
            this.salt = salt;
            this.key = key;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(salt);
            writer.WriteVarInt(key.Count());
            foreach (var entry in key)
            {
                 writer.WriteByte(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            salt = reader.ReadUTF();
            var limit = reader.ReadVarInt();
            key = new byte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (key as byte[])[i] = reader.ReadByte();
            }
        }
        
    }
    
}