

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PartyMemberArenaInformations : PartyMemberInformations
    {
        public override short TypeId => 391;
        
        public ushort rank;
        
        public PartyMemberArenaInformations()
        {
        }
        
        public PartyMemberArenaInformations(double id, string name, byte level, Types.EntityLook entityLook, sbyte breed, bool sex, uint lifePoints, uint maxLifePoints, ushort prospecting, byte regenRate, ushort initiative, sbyte alignmentSide, short worldX, short worldY, int mapId, ushort subAreaId, Types.PlayerStatus status, IEnumerable<Types.PartyCompanionMemberInformations> companions, ushort rank)
         : base(id, name, level, entityLook, breed, sex, lifePoints, maxLifePoints, prospecting, regenRate, initiative, alignmentSide, worldX, worldY, mapId, subAreaId, status, companions)
        {
            this.rank = rank;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)rank);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            rank = reader.ReadVarUhShort();
        }
        
    }
    
}