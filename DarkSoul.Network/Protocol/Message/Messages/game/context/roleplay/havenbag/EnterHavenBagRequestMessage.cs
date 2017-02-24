

// Generated on 02/23/2017 16:53:36
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class EnterHavenBagRequestMessage : NetworkMessage
    {
        public override ushort Id => 6636;
        
        
        public double havenBagOwner;
        
        public EnterHavenBagRequestMessage()
        {
        }
        
        public EnterHavenBagRequestMessage(double havenBagOwner)
        {
            this.havenBagOwner = havenBagOwner;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(havenBagOwner);
        }
        
        public override void Deserialize(IReader reader)
        {
            havenBagOwner = reader.ReadVarUhLong();
        }
        
    }
    
}