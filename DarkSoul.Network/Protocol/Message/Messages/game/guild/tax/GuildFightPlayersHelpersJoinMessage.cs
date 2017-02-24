

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
    public class GuildFightPlayersHelpersJoinMessage : NetworkMessage
    {
        public override ushort Id => 5720;
        
        
        public int fightId;
        public Types.CharacterMinimalPlusLookInformations playerInfo;
        
        public GuildFightPlayersHelpersJoinMessage()
        {
        }
        
        public GuildFightPlayersHelpersJoinMessage(int fightId, Types.CharacterMinimalPlusLookInformations playerInfo)
        {
            this.fightId = fightId;
            this.playerInfo = playerInfo;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(fightId);
            playerInfo.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            fightId = reader.ReadInt();
            playerInfo = new Types.CharacterMinimalPlusLookInformations();
            playerInfo.Deserialize(reader);
        }
        
    }
    
}