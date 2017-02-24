

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
    public class NpcDialogReplyMessage : NetworkMessage
    {
        public override ushort Id => 5616;
        
        
        public ushort replyId;
        
        public NpcDialogReplyMessage()
        {
        }
        
        public NpcDialogReplyMessage(ushort replyId)
        {
            this.replyId = replyId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)replyId);
        }
        
        public override void Deserialize(IReader reader)
        {
            replyId = reader.ReadVarUhShort();
        }
        
    }
    
}