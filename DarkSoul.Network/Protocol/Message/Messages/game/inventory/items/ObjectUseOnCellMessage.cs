

// Generated on 02/23/2017 16:53:59
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ObjectUseOnCellMessage : ObjectUseMessage
    {
        public override ushort Id => 3013;
        
        
        public ushort cells;
        
        public ObjectUseOnCellMessage()
        {
        }
        
        public ObjectUseOnCellMessage(uint objectUID, ushort cells)
         : base(objectUID)
        {
            this.cells = cells;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)cells);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            cells = reader.ReadVarUhShort();
        }
        
    }
    
}