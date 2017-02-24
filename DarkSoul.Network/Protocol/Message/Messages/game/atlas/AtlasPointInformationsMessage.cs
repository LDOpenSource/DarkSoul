

// Generated on 02/23/2017 16:53:23
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AtlasPointInformationsMessage : NetworkMessage
    {
        public override ushort Id => 5956;
        
        
        public Types.AtlasPointsInformations type;
        
        public AtlasPointInformationsMessage()
        {
        }
        
        public AtlasPointInformationsMessage(Types.AtlasPointsInformations type)
        {
            this.type = type;
        }
        
        public override void Serialize(IWriter writer)
        {
            type.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            type = new Types.AtlasPointsInformations();
            type.Deserialize(reader);
        }
        
    }
    
}