

// Generated on 02/23/2017 16:53:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DungeonPartyFinderRoomContentMessage : NetworkMessage
    {
        public override ushort Id => 6247;
        
        
        public ushort dungeonId;
        public IEnumerable<Types.DungeonPartyFinderPlayer> players;
        
        public DungeonPartyFinderRoomContentMessage()
        {
        }
        
        public DungeonPartyFinderRoomContentMessage(ushort dungeonId, IEnumerable<Types.DungeonPartyFinderPlayer> players)
        {
            this.dungeonId = dungeonId;
            this.players = players;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)dungeonId);
            writer.WriteShort((short)players.Count());
            foreach (var entry in players)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            dungeonId = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            players = new Types.DungeonPartyFinderPlayer[limit];
            for (int i = 0; i < limit; i++)
            {
                 (players as Types.DungeonPartyFinderPlayer[])[i] = new Types.DungeonPartyFinderPlayer();
                 (players as Types.DungeonPartyFinderPlayer[])[i].Deserialize(reader);
            }
        }
        
    }
    
}