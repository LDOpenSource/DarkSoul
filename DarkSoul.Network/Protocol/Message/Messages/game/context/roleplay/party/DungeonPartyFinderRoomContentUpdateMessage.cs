

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
    public class DungeonPartyFinderRoomContentUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6250;
        
        
        public ushort dungeonId;
        public IEnumerable<Types.DungeonPartyFinderPlayer> addedPlayers;
        public IEnumerable<double> removedPlayersIds;
        
        public DungeonPartyFinderRoomContentUpdateMessage()
        {
        }
        
        public DungeonPartyFinderRoomContentUpdateMessage(ushort dungeonId, IEnumerable<Types.DungeonPartyFinderPlayer> addedPlayers, IEnumerable<double> removedPlayersIds)
        {
            this.dungeonId = dungeonId;
            this.addedPlayers = addedPlayers;
            this.removedPlayersIds = removedPlayersIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)dungeonId);
            writer.WriteShort((short)addedPlayers.Count());
            foreach (var entry in addedPlayers)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)removedPlayersIds.Count());
            foreach (var entry in removedPlayersIds)
            {
                 writer.WriteVarLong(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            dungeonId = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            addedPlayers = new Types.DungeonPartyFinderPlayer[limit];
            for (int i = 0; i < limit; i++)
            {
                 (addedPlayers as Types.DungeonPartyFinderPlayer[])[i] = new Types.DungeonPartyFinderPlayer();
                 (addedPlayers as Types.DungeonPartyFinderPlayer[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            removedPlayersIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (removedPlayersIds as double[])[i] = reader.ReadVarUhLong();
            }
        }
        
    }
    
}