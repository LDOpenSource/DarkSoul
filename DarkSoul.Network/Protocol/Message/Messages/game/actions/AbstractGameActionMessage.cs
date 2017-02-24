

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
    public class AbstractGameActionMessage : NetworkMessage
    {
        public override ushort Id => 1000;
        
        
        public ushort actionId;
        public double sourceId;
        
        public AbstractGameActionMessage()
        {
        }
        
        public AbstractGameActionMessage(ushort actionId, double sourceId)
        {
            this.actionId = actionId;
            this.sourceId = sourceId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)actionId);
            writer.WriteDouble(sourceId);
        }
        
        public override void Deserialize(IReader reader)
        {
            actionId = reader.ReadVarUhShort();
            sourceId = reader.ReadDouble();
        }
        
    }
    
}