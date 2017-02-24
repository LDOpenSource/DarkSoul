

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
    public class MapComplementaryInformationsDataInHouseMessage : MapComplementaryInformationsDataMessage
    {
        public override ushort Id => 6130;
        
        
        public Types.HouseInformationsInside currentHouse;
        
        public MapComplementaryInformationsDataInHouseMessage()
        {
        }
        
        public MapComplementaryInformationsDataInHouseMessage(ushort subAreaId, int mapId, IEnumerable<Types.HouseInformations> houses, IEnumerable<Types.GameRolePlayActorInformations> actors, IEnumerable<Types.InteractiveElement> interactiveElements, IEnumerable<Types.StatedElement> statedElements, IEnumerable<Types.MapObstacle> obstacles, IEnumerable<Types.FightCommonInformations> fights, bool hasAggressiveMonsters, Types.FightStartingPositions fightStartPositions, Types.HouseInformationsInside currentHouse)
         : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights, hasAggressiveMonsters, fightStartPositions)
        {
            this.currentHouse = currentHouse;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            currentHouse.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            currentHouse = new Types.HouseInformationsInside();
            currentHouse.Deserialize(reader);
        }
        
    }
    
}