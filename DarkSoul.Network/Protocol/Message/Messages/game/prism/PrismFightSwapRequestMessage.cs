

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
    public class PrismFightSwapRequestMessage : NetworkMessage
    {
        public override ushort Id => 5901;
        
        
        public ushort subAreaId;
        public double targetId;
        
        public PrismFightSwapRequestMessage()
        {
        }
        
        public PrismFightSwapRequestMessage(ushort subAreaId, double targetId)
        {
            this.subAreaId = subAreaId;
            this.targetId = targetId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)subAreaId);
            writer.WriteVarLong(targetId);
        }
        
        public override void Deserialize(IReader reader)
        {
            subAreaId = reader.ReadVarUhShort();
            targetId = reader.ReadVarUhLong();
        }
        
    }
    
}