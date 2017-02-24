

// Generated on 02/23/2017 16:53:50
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class IdolPartyRegisterRequestMessage : NetworkMessage
    {
        public override ushort Id => 6582;
        
        
        public bool register;
        
        public IdolPartyRegisterRequestMessage()
        {
        }
        
        public IdolPartyRegisterRequestMessage(bool register)
        {
            this.register = register;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(register);
        }
        
        public override void Deserialize(IReader reader)
        {
            register = reader.ReadBoolean();
        }
        
    }
    
}