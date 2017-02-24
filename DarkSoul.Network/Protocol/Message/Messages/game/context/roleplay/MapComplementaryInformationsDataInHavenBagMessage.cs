

// Generated on 02/23/2017 16:53:33
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MapComplementaryInformationsDataInHavenBagMessage : MapComplementaryInformationsDataMessage
    {
        public override ushort Id => 6622;
        
        
        public Types.CharacterMinimalInformations ownerInformations;
        public sbyte theme;
        public sbyte roomId;
        public sbyte maxRoomId;
        
        public MapComplementaryInformationsDataInHavenBagMessage()
        {
        }
        
        public MapComplementaryInformationsDataInHavenBagMessage(ushort subAreaId, int mapId, IEnumerable<Types.HouseInformations> houses, IEnumerable<Types.GameRolePlayActorInformations> actors, IEnumerable<Types.InteractiveElement> interactiveElements, IEnumerable<Types.StatedElement> statedElements, IEnumerable<Types.MapObstacle> obstacles, IEnumerable<Types.FightCommonInformations> fights, bool hasAggressiveMonsters, Types.FightStartingPositions fightStartPositions, Types.CharacterMinimalInformations ownerInformations, sbyte theme, sbyte roomId, sbyte maxRoomId)
         : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights, hasAggressiveMonsters, fightStartPositions)
        {
            this.ownerInformations = ownerInformations;
            this.theme = theme;
            this.roomId = roomId;
            this.maxRoomId = maxRoomId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            ownerInformations.Serialize(writer);
            writer.WriteSByte(theme);
            writer.WriteSByte(roomId);
            writer.WriteSByte(maxRoomId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            ownerInformations = new Types.CharacterMinimalInformations();
            ownerInformations.Deserialize(reader);
            theme = reader.ReadSByte();
            roomId = reader.ReadSByte();
            maxRoomId = reader.ReadSByte();
        }
        
    }
    
}