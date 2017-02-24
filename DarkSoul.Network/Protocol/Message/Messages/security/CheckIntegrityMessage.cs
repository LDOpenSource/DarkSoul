

// Generated on 02/23/2017 16:54:04
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CheckIntegrityMessage : NetworkMessage
    {
        public override ushort Id => 6372;
        
        
        public IEnumerable<sbyte> data;
        
        public CheckIntegrityMessage()
        {
        }
        
        public CheckIntegrityMessage(IEnumerable<sbyte> data)
        {
            this.data = data;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)data.Count());
            foreach (var entry in data)
            {
                 writer.WriteSByte(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadVarInt();
            data = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (data as sbyte[])[i] = reader.ReadSByte();
            }
        }
        
    }
    
}