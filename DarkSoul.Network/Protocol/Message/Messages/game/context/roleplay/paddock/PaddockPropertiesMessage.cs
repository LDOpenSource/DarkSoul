

// Generated on 02/23/2017 16:53:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PaddockPropertiesMessage : NetworkMessage
    {
        public override ushort Id => 5824;
        
        
        public Types.PaddockInstancesInformations properties;
        
        public PaddockPropertiesMessage()
        {
        }
        
        public PaddockPropertiesMessage(Types.PaddockInstancesInformations properties)
        {
            this.properties = properties;
        }
        
        public override void Serialize(IWriter writer)
        {
            properties.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            properties = new Types.PaddockInstancesInformations();
            properties.Deserialize(reader);
        }
        
    }
    
}