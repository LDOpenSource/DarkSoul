

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
    public class GuildFightLeaveRequestMessage : NetworkMessage
    {
        public override ushort Id => 5715;
        
        
        public int taxCollectorId;
        public double characterId;
        
        public GuildFightLeaveRequestMessage()
        {
        }
        
        public GuildFightLeaveRequestMessage(int taxCollectorId, double characterId)
        {
            this.taxCollectorId = taxCollectorId;
            this.characterId = characterId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(taxCollectorId);
            writer.WriteVarLong(characterId);
        }
        
        public override void Deserialize(IReader reader)
        {
            taxCollectorId = reader.ReadInt();
            characterId = reader.ReadVarUhLong();
        }
        
    }
    
}