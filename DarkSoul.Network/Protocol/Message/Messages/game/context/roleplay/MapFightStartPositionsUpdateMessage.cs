

// Generated on 02/23/2017 16:53:34
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MapFightStartPositionsUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6716;
        
        
        public int mapId;
        public Types.FightStartingPositions fightStartPositions;
        
        public MapFightStartPositionsUpdateMessage()
        {
        }
        
        public MapFightStartPositionsUpdateMessage(int mapId, Types.FightStartingPositions fightStartPositions)
        {
            this.mapId = mapId;
            this.fightStartPositions = fightStartPositions;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(mapId);
            fightStartPositions.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            mapId = reader.ReadInt();
            fightStartPositions = new Types.FightStartingPositions();
            fightStartPositions.Deserialize(reader);
        }
        
    }
    
}