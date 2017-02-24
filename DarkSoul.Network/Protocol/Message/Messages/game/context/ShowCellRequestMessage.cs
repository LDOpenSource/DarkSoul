

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
    public class ShowCellRequestMessage : NetworkMessage
    {
        public override ushort Id => 5611;
        
        
        public ushort cellId;
        
        public ShowCellRequestMessage()
        {
        }
        
        public ShowCellRequestMessage(ushort cellId)
        {
            this.cellId = cellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)cellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            cellId = reader.ReadVarUhShort();
        }
        
    }
    
}