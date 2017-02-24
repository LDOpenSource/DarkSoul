

// Generated on 02/23/2017 16:53:29
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ShowCellMessage : NetworkMessage
    {
        public override ushort Id => 5612;
        
        
        public double sourceId;
        public ushort cellId;
        
        public ShowCellMessage()
        {
        }
        
        public ShowCellMessage(double sourceId, ushort cellId)
        {
            this.sourceId = sourceId;
            this.cellId = cellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(sourceId);
            writer.WriteVarShort((int)cellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            sourceId = reader.ReadDouble();
            cellId = reader.ReadVarUhShort();
        }
        
    }
    
}