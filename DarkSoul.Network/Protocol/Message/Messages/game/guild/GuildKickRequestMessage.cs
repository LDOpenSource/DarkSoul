

// Generated on 02/23/2017 16:53:48
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildKickRequestMessage : NetworkMessage
    {
        public override ushort Id => 5887;
        
        
        public double kickedId;
        
        public GuildKickRequestMessage()
        {
        }
        
        public GuildKickRequestMessage(double kickedId)
        {
            this.kickedId = kickedId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(kickedId);
        }
        
        public override void Deserialize(IReader reader)
        {
            kickedId = reader.ReadVarUhLong();
        }
        
    }
    
}