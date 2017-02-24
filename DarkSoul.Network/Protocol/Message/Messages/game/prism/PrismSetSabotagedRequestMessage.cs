

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
    public class PrismSetSabotagedRequestMessage : NetworkMessage
    {
        public override ushort Id => 6468;
        
        
        public ushort subAreaId;
        
        public PrismSetSabotagedRequestMessage()
        {
        }
        
        public PrismSetSabotagedRequestMessage(ushort subAreaId)
        {
            this.subAreaId = subAreaId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)subAreaId);
        }
        
        public override void Deserialize(IReader reader)
        {
            subAreaId = reader.ReadVarUhShort();
        }
        
    }
    
}