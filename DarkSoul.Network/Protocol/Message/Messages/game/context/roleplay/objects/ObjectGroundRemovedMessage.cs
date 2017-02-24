

// Generated on 02/23/2017 16:53:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ObjectGroundRemovedMessage : NetworkMessage
    {
        public override ushort Id => 3014;
        
        
        public ushort cell;
        
        public ObjectGroundRemovedMessage()
        {
        }
        
        public ObjectGroundRemovedMessage(ushort cell)
        {
            this.cell = cell;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)cell);
        }
        
        public override void Deserialize(IReader reader)
        {
            cell = reader.ReadVarUhShort();
        }
        
    }
    
}