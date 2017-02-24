

// Generated on 02/23/2017 16:53:22
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AllianceKickRequestMessage : NetworkMessage
    {
        public override ushort Id => 0x1900;
        
        
        public uint kickedId;
        
        public AllianceKickRequestMessage()
        {
        }
        
        public AllianceKickRequestMessage(uint kickedId)
        {
            this.kickedId = kickedId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)kickedId);
        }
        
        public override void Deserialize(IReader reader)
        {
            kickedId = reader.ReadVarUhInt();
        }
        
    }
    
}