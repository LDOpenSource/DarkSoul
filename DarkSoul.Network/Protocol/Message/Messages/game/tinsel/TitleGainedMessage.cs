

// Generated on 02/23/2017 16:54:03
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TitleGainedMessage : NetworkMessage
    {
        public override ushort Id => 6364;
        
        
        public ushort titleId;
        
        public TitleGainedMessage()
        {
        }
        
        public TitleGainedMessage(ushort titleId)
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