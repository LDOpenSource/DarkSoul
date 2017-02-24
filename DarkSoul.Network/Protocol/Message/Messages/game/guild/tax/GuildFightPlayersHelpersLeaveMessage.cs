

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
    public class GuildFightPlayersHelpersLeaveMessage : NetworkMessage
    {
        public override ushort Id => 5719;
        
        
        public int fightId;
        public double playerId;
        
        public GuildFightPlayersHelpersLeaveMessage()
        {
        }
        
        public GuildFightPlayersHelpersLeaveMessage(int fightId, double playerId)
        {
            this.fightId = fightId;
            this.playerId = playerId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(fightId);
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IReader reader)
        {
            fightId = reader.ReadInt();
            playerId = reader.ReadVarUhLong();
        }
        
    }
    
}