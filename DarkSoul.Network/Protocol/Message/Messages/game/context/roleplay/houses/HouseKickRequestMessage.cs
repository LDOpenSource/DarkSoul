

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
    public class HouseKickRequestMessage : NetworkMessage
    {
        public override ushort Id => 5698;
        
        
        public double id;
        
        public HouseKickRequestMessage()
        {
        }
        
        public HouseKickRequestMessage(double id)
        {
            this.id = id;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(id);
        }
        
        public override void Deserialize(IReader reader)
        {
            id = reader.ReadVarUhLong();
        }
        
    }
    
}