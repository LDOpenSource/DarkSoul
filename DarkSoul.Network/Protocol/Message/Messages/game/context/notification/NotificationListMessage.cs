

// Generated on 02/23/2017 16:53:33
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class NotificationListMessage : NetworkMessage
    {
        public override ushort Id => 6087;
        
        
        public IEnumerable<int> flags;
        
        public NotificationListMessage()
        {
        }
        
        public NotificationListMessage(IEnumerable<int> flags)
        {
            this.flags = flags;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)flags.Count());
            foreach (var entry in flags)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            flags = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (flags as int[])[i] = reader.ReadVarInt();
            }
        }
        
    }
    
}