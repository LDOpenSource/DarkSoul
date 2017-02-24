

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
    public class MapComplementaryInformationsWithCoordsMessage : MapComplementaryInformationsDataMessage
    {
        public override ushort Id => 6268;
        
        
        public short worldX;
        public short worldY;
        
        public MapComplementaryInformationsWithCoordsMessage()
        {
        }
        
        public MapComplementaryInformationsWithCoordsMessage(ushort subAreaId, int mapId, IEnumerable<Types.HouseInformations> houses, IEnumerable<Types.GameRolePlayActorInformations> actors, IEnumerable<Types.InteractiveElement> interactiveElements, IEnumerable<Types.StatedElement> statedElements, IEnumerable<Types.MapObstacle> obstacles, IEnumerable<Types.FightCommonInformations> fights, bool hasAggressiveMonsters, Types.FightStartingPositions fightStartPositions, short worldX, short worldY)
         : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights, hasAggressiveMonsters, fightStartPositions)
        {
            this.worldX = worldX;
            this.worldY = worldY;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
        }
        
    }
    
}