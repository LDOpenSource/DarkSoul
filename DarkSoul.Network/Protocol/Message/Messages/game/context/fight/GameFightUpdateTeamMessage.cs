

// Generated on 02/23/2017 16:53:31
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightUpdateTeamMessage : NetworkMessage
    {
        public override ushort Id => 5572;
        
        
        public short fightId;
        public Types.FightTeamInformations team;
        
        public GameFightUpdateTeamMessage()
        {
        }
        
        public GameFightUpdateTeamMessage(short fightId, Types.FightTeamInformations team)
        {
            this.fightId = fightId;
            this.team = team;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(fightId);
            team.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            fightId = reader.ReadShort();
            team = new Types.FightTeamInformations();
            team.Deserialize(reader);
        }
        
    }
    
}