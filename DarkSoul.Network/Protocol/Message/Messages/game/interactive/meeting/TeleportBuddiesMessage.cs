

// Generated on 02/23/2017 16:53:51
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TeleportBuddiesMessage : NetworkMessage
    {
        public override ushort Id => 6289;
        
        
        public ushort dungeonId;
        
        public TeleportBuddiesMessage()
        {
        }
        
        public TeleportBuddiesMessage(ushort dungeonId)
        {
            this.dungeonId = dungeonId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)dungeonId);
        }
        
        public override void Deserialize(IReader reader)
        {
            dungeonId = reader.ReadVarUhShort();
        }
        
    }
    
}