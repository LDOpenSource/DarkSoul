

// Generated on 02/23/2017 16:53:17
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AbstractGameActionWithAckMessage : AbstractGameActionMessage
    {
        public override ushort Id => 1001;
        
        
        public short waitAckId;
        
        public AbstractGameActionWithAckMessage()
        {
        }
        
        public AbstractGameActionWithAckMessage(ushort actionId, double sourceId, short waitAckId)
         : base(actionId, sourceId)
        {
            this.waitAckId = waitAckId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(waitAckId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            waitAckId = reader.ReadShort();
        }
        
    }
    
}