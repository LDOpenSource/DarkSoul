

// Generated on 02/23/2017 16:53:35
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class EmoteListMessage : NetworkMessage
    {
        public override ushort Id => 5689;
        
        
        public IEnumerable<byte> emoteIds;
        
        public EmoteListMessage()
        {
        }
        
        public EmoteListMessage(IEnumerable<byte> emoteIds)
        {
            this.emoteIds = emoteIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)emoteIds.Count());
            foreach (var entry in emoteIds)
            {
                 writer.WriteByte(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            emoteIds = new byte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (emoteIds as byte[])[i] = reader.ReadByte();
            }
        }
        
    }
    
}