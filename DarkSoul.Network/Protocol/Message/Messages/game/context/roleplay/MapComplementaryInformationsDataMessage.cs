

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
    public class MapComplementaryInformationsDataMessage : NetworkMessage
    {
        public override ushort Id => 226;
        
        
        public ushort subAreaId;
        public int mapId;
        public IEnumerable<Types.HouseInformations> houses;
        public IEnumerable<Types.GameRolePlayActorInformations> actors;
        public IEnumerable<Types.InteractiveElement> interactiveElements;
        public IEnumerable<Types.StatedElement> statedElements;
        public IEnumerable<Types.MapObstacle> obstacles;
        public IEnumerable<Types.FightCommonInformations> fights;
        public bool hasAggressiveMonsters;
        public Types.FightStartingPositions fightStartPositions;
        
        public MapComplementaryInformationsDataMessage()
        {
        }
        
        public MapComplementaryInformationsDataMessage(ushort subAreaId, int mapId, IEnumerable<Types.HouseInformations> houses, IEnumerable<Types.GameRolePlayActorInformations> actors, IEnumerable<Types.InteractiveElement> interactiveElements, IEnumerable<Types.StatedElement> statedElements, IEnumerable<Types.MapObstacle> obstacles, IEnumerable<Types.FightCommonInformations> fights, bool hasAggressiveMonsters, Types.FightStartingPositions fightStartPositions)
        {
            this.subAreaId = subAreaId;
            this.mapId = mapId;
            this.houses = houses;
            this.actors = actors;
            this.interactiveElements = interactiveElements;
            this.statedElements = statedElements;
            this.obstacles = obstacles;
            this.fights = fights;
            this.hasAggressiveMonsters = hasAggressiveMonsters;
            this.fightStartPositions = fightStartPositions;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)subAreaId);
            writer.WriteInt(mapId);
            writer.WriteShort((short)houses.Count());
            foreach (var entry in houses)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)actors.Count());
            foreach (var entry in actors)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)interactiveElements.Count());
            foreach (var entry in interactiveElements)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)statedElements.Count());
            foreach (var entry in statedElements)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)obstacles.Count());
            foreach (var entry in obstacles)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)fights.Count());
            foreach (var entry in fights)
            {
                 entry.Serialize(writer);
            }
            writer.WriteBoolean(hasAggressiveMonsters);
            fightStartPositions.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            subAreaId = reader.ReadVarUhShort();
            mapId = reader.ReadInt();
            var limit = reader.ReadUShort();
            houses = new Types.HouseInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (houses as Types.HouseInformations[])[i] = ProtocolTypeManager.GetInstance<Types.HouseInformations>(reader.ReadUShort());
                 (houses as Types.HouseInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            actors = new Types.GameRolePlayActorInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (actors as Types.GameRolePlayActorInformations[])[i] = ProtocolTypeManager.GetInstance<Types.GameRolePlayActorInformations>(reader.ReadUShort());
                 (actors as Types.GameRolePlayActorInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            interactiveElements = new Types.InteractiveElement[limit];
            for (int i = 0; i < limit; i++)
            {
                 (interactiveElements as Types.InteractiveElement[])[i] = ProtocolTypeManager.GetInstance<Types.InteractiveElement>(reader.ReadUShort());
                 (interactiveElements as Types.InteractiveElement[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            statedElements = new Types.StatedElement[limit];
            for (int i = 0; i < limit; i++)
            {
                 (statedElements as Types.StatedElement[])[i] = new Types.StatedElement();
                 (statedElements as Types.StatedElement[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            obstacles = new Types.MapObstacle[limit];
            for (int i = 0; i < limit; i++)
            {
                 (obstacles as Types.MapObstacle[])[i] = new Types.MapObstacle();
                 (obstacles as Types.MapObstacle[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            fights = new Types.FightCommonInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (fights as Types.FightCommonInformations[])[i] = new Types.FightCommonInformations();
                 (fights as Types.FightCommonInformations[])[i].Deserialize(reader);
            }
            hasAggressiveMonsters = reader.ReadBoolean();
            fightStartPositions = new Types.FightStartingPositions();
            fightStartPositions.Deserialize(reader);
        }
        
    }
    
}