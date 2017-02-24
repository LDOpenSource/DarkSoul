

// Generated on 02/23/2017 16:53:34
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TeleportOnSameMapMessage : NetworkMessage
    {
        public override ushort Id => 6048;
        
        
        public double targetId;
        public ushort cellId;
        
        public TeleportOnSameMapMessage()
        {
        }
        
        public TeleportOnSameMapMessage(double targetId, ushort cellId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(targetId);
            writer.WriteVarShort((int)cellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            targetId = reader.ReadDouble();
            cellId = reader.ReadVarUhShort();
        }
        
    }
    
}