

// Generated on 02/23/2017 16:53:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PortalUseRequestMessage : NetworkMessage
    {
        public override ushort Id => 6492;
        
        
        public uint portalId;
        
        public PortalUseRequestMessage()
        {
        }
        
        public PortalUseRequestMessage(uint portalId)
        {
            this.portalId = portalId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)portalId);
        }
        
        public override void Deserialize(IReader reader)
        {
            portalId = reader.ReadVarUhInt();
        }
        
    }
    
}