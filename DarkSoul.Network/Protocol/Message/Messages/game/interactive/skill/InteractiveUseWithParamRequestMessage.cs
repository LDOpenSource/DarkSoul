

// Generated on 02/23/2017 16:53:51
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class InteractiveUseWithParamRequestMessage : InteractiveUseRequestMessage
    {
        public override ushort Id => 6715;
        
        
        public int id;
        
        public InteractiveUseWithParamRequestMessage()
        {
        }
        
        public InteractiveUseWithParamRequestMessage(uint elemId, uint skillInstanceUid, int id)
         : base(elemId, skillInstanceUid)
        {
            this.id = id;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(id);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            id = reader.ReadInt();
        }
        
    }
    
}