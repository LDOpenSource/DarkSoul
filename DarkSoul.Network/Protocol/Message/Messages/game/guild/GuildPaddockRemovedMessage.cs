

// Generated on 02/23/2017 16:53:49
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildPaddockRemovedMessage : NetworkMessage
    {
        public override ushort Id => 5955;
        
        
        public int paddockId;
        
        public GuildPaddockRemovedMessage()
        {
        }
        
        public GuildPaddockRemovedMessage(int paddockId)
        {
            this.paddockId = paddockId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(paddockId);
        }
        
        public override void Deserialize(IReader reader)
        {
            paddockId = reader.ReadInt();
        }
        
    }
    
}