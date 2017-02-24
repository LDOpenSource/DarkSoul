

// Generated on 02/23/2017 16:53:36
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameRolePlayArenaUpdatePlayerInfosWithTeamMessage : GameRolePlayArenaUpdatePlayerInfosMessage
    {
        public override ushort Id => 6640;
        
        
        public Types.ArenaRankInfos team;
        
        public GameRolePlayArenaUpdatePlayerInfosWithTeamMessage()
        {
        }
        
        public GameRolePlayArenaUpdatePlayerInfosWithTeamMessage(Types.ArenaRankInfos solo, Types.ArenaRankInfos team)
         : base(solo)
        {
            this.team = team;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            team.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            team = new Types.ArenaRankInfos();
            team.Deserialize(reader);
        }
        
    }
    
}