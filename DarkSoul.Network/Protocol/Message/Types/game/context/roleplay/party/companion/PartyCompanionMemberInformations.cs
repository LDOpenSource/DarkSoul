

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PartyCompanionMemberInformations : PartyCompanionBaseInformations
    {
        public override short TypeId => 452;
        
        public ushort initiative;
        public uint lifePoints;
        public uint maxLifePoints;
        public ushort prospecting;
        public byte regenRate;
        
        public PartyCompanionMemberInformations()
        {
        }
        
        public PartyCompanionMemberInformations(sbyte indexId, sbyte companionGenericId, Types.EntityLook entityLook, ushort initiative, uint lifePoints, uint maxLifePoints, ushort prospecting, byte regenRate)
         : base(indexId, companionGenericId, entityLook)
        {
            this.initiative = initiative;
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
            this.prospecting = prospecting;
            this.regenRate = regenRate;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)initiative);
            writer.WriteVarInt((int)lifePoints);
            writer.WriteVarInt((int)maxLifePoints);
            writer.WriteVarShort((int)prospecting);
            writer.WriteByte(regenRate);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            initiative = reader.ReadVarUhShort();
            lifePoints = reader.ReadVarUhInt();
            maxLifePoints = reader.ReadVarUhInt();
            prospecting = reader.ReadVarUhShort();
            regenRate = reader.ReadByte();
        }
        
    }
    
}