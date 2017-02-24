

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
    public class GuildFightPlayersEnemiesListMessage : NetworkMessage
    {
        public override ushort Id => 5928;
        
        
        public int fightId;
        public IEnumerable<Types.CharacterMinimalPlusLookInformations> playerInfo;
        
        public GuildFightPlayersEnemiesListMessage()
        {
        }
        
        public GuildFightPlayersEnemiesListMessage(int fightId, IEnumerable<Types.CharacterMinimalPlusLookInformations> playerInfo)
        {
            this.fightId = fightId;
            this.playerInfo = playerInfo;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(fightId);
            writer.WriteShort((short)playerInfo.Count());
            foreach (var entry in playerInfo)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            fightId = reader.ReadInt();
            var limit = reader.ReadUShort();
            playerInfo = new Types.CharacterMinimalPlusLookInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (playerInfo as Types.CharacterMinimalPlusLookInformations[])[i] = new Types.CharacterMinimalPlusLookInformations();
                 (playerInfo as Types.CharacterMinimalPlusLookInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}