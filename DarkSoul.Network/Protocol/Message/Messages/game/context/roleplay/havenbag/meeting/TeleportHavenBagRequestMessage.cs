

// Generated on 02/23/2017 16:53:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TeleportHavenBagRequestMessage : NetworkMessage
    {
        public override ushort Id => 6647;
        
        
        public double guestId;
        
        public TeleportHavenBagRequestMessage()
        {
        }
        
        public TeleportHavenBagRequestMessage(double guestId)
        {
            this.guestId = guestId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(guestId);
        }
        
        public override void Deserialize(IReader reader)
        {
            guestId = reader.ReadVarUhLong();
        }
        
    }
    
}