

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
    public class IdolPartyLostMessage : NetworkMessage
    {
        public override ushort Id => 6580;
        
        
        public ushort idolId;
        
        public IdolPartyLostMessage()
        {
        }
        
        public IdolPartyLostMessage(ushort idolId)
        {
            this.idolId = idolId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)idolId);
        }
        
        public override void Deserialize(IReader reader)
        {
            idolId = reader.ReadVarUhShort();
        }
        
    }
    
}