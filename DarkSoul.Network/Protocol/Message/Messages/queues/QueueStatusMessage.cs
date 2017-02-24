

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
    public class QueueStatusMessage : NetworkMessage
    {
        public override ushort Id => 6100;
        
        
        public ushort position;
        public ushort total;
        
        public QueueStatusMessage()
        {
        }
        
        public QueueStatusMessage(ushort position, ushort total)
        {
            this.position = position;
            this.total = total;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUShort(position);
            writer.WriteUShort(total);
        }
        
        public override void Deserialize(IReader reader)
        {
            position = reader.ReadUShort();
            total = reader.ReadUShort();
        }
        
    }
    
}