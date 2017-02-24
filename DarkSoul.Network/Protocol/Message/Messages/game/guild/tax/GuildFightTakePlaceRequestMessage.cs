

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
    public class GuildFightTakePlaceRequestMessage : GuildFightJoinRequestMessage
    {
        public override ushort Id => 6235;
        
        
        public int replacedCharacterId;
        
        public GuildFightTakePlaceRequestMessage()
        {
        }
        
        public GuildFightTakePlaceRequestMessage(int taxCollectorId, int replacedCharacterId)
         : base(taxCollectorId)
        {
            this.replacedCharacterId = replacedCharacterId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(replacedCharacterId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            replacedCharacterId = reader.ReadInt();
        }
        
    }
    
}