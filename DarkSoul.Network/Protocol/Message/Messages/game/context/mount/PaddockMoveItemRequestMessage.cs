

// Generated on 02/23/2017 16:53:33
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PaddockMoveItemRequestMessage : NetworkMessage
    {
        public override ushort Id => 6052;
        
        
        public ushort oldCellId;
        public ushort newCellId;
        
        public PaddockMoveItemRequestMessage()
        {
        }
        
        public PaddockMoveItemRequestMessage(ushort oldCellId, ushort newCellId)
        {
            this.oldCellId = oldCellId;
            this.newCellId = newCellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)oldCellId);
            writer.WriteVarShort((int)newCellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            oldCellId = reader.ReadVarUhShort();
            newCellId = reader.ReadVarUhShort();
        }
        
    }
    
}