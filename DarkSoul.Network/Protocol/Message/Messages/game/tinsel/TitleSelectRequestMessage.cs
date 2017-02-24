

// Generated on 02/23/2017 16:54:04
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TitleSelectRequestMessage : NetworkMessage
    {
        public override ushort Id => 6365;
        
        
        public ushort titleId;
        
        public TitleSelectRequestMessage()
        {
        }
        
        public TitleSelectRequestMessage(ushort titleId)
        {
            this.titleId = titleId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)titleId);
        }
        
        public override void Deserialize(IReader reader)
        {
            titleId = reader.ReadVarUhShort();
        }
        
    }
    
}