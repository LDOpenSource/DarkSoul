

// Generated on 02/23/2017 16:53:27
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class LocalizedChatSmileyMessage : ChatSmileyMessage
    {
        public override ushort Id => 6185;
        
        
        public ushort cellId;
        
        public LocalizedChatSmileyMessage()
        {
        }
        
        public LocalizedChatSmileyMessage(double entityId, ushort smileyId, int accountId, ushort cellId)
         : base(entityId, smileyId, accountId)
        {
            this.cellId = cellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)cellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            cellId = reader.ReadVarUhShort();
        }
        
    }
    
}