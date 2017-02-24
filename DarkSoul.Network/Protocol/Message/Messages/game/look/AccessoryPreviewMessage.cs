

// Generated on 02/23/2017 16:54:01
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AccessoryPreviewMessage : NetworkMessage
    {
        public override ushort Id => 6517;
        
        
        public Types.EntityLook look;
        
        public AccessoryPreviewMessage()
        {
        }
        
        public AccessoryPreviewMessage(Types.EntityLook look)
        {
            this.look = look;
        }
        
        public override void Serialize(IWriter writer)
        {
            look.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            look = new Types.EntityLook();
            look.Deserialize(reader);
        }
        
    }
    
}