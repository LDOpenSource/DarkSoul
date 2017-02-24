

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
    public class NotificationUpdateFlagMessage : NetworkMessage
    {
        public override ushort Id => 6090;
        
        
        public ushort index;
        
        public NotificationUpdateFlagMessage()
        {
        }
        
        public NotificationUpdateFlagMessage(ushort index)
        {
            this.index = index;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)index);
        }
        
        public override void Deserialize(IReader reader)
        {
            index = reader.ReadVarUhShort();
        }
        
    }
    
}