

// Generated on 02/23/2017 16:53:21
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AllianceGuildLeavingMessage : NetworkMessage
    {
        public override ushort Id => 6399;
        
        
        public bool kicked;
        public uint guildId;
        
        public AllianceGuildLeavingMessage()
        {
        }
        
        public AllianceGuildLeavingMessage(bool kicked, uint guildId)
        {
            this.kicked = kicked;
            this.guildId = guildId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(kicked);
            writer.WriteVarInt((int)guildId);
        }
        
        public override void Deserialize(IReader reader)
        {
            kicked = reader.ReadBoolean();
            guildId = reader.ReadVarUhInt();
        }
        
    }
    
}