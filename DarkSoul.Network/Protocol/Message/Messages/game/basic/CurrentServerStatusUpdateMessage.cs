

// Generated on 02/23/2017 16:53:24
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CurrentServerStatusUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6525;
        
        
        public sbyte status;
        
        public CurrentServerStatusUpdateMessage()
        {
        }
        
        public CurrentServerStatusUpdateMessage(sbyte status)
        {
            this.status = status;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(status);
        }
        
        public override void Deserialize(IReader reader)
        {
            status = reader.ReadSByte();
        }
        
    }
    
}