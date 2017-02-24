

// Generated on 02/23/2017 16:54:02
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SetEnablePVPRequestMessage : NetworkMessage
    {
        public override ushort Id => 1810;
        
        
        public bool enable;
        
        public SetEnablePVPRequestMessage()
        {
        }
        
        public SetEnablePVPRequestMessage(bool enable)
        {
            this.enable = enable;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(enable);
        }
        
        public override void Deserialize(IReader reader)
        {
            enable = reader.ReadBoolean();
        }
        
    }
    
}