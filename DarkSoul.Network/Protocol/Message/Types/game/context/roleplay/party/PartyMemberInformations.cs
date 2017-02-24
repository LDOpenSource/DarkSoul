

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PartyMemberInformations : CharacterBaseInformations
    {
        public override short TypeId => 90;
        
        public uint lifePoints;
        public uint maxLifePoints;
        public ushort prospecting;
        public byte regenRate;
        public ushort initiative;
        public sbyte alignmentSide;
        public short worldX;
        public short worldY;
        public int mapId;
        public ushort subAreaId;
        public Types.PlayerStatus status;
        public IEnumerable<Types.PartyCompanionMemberInformations> companions;
        
        public PartyMemberInformations()
        {
        }
        
        public PartyMemberInformations(double id, string name, byte level, Types.EntityLook entityLook, sbyte breed, bool sex, uint lifePoints, uint maxLifePoints, ushort prospecting, byte regenRate, ushort initiative, sbyte alignmentSide, short worldX, short worldY, int mapId, ushort subAreaId, Types.PlayerStatus status, IEnumerable<Types.PartyCompanionMemberInformations> companions)
         : base(id, name, level, entityLook, breed, sex)
        {
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
            this.prospecting = prospecting;
            this.regenRate = regenRate;
            this.initiative = initiative;
            this.alignmentSide = alignmentSide;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.status = status;
            this.companions = companions;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)lifePoints);
            writer.WriteVarInt((int)maxLifePoints);
            writer.WriteVarShort((int)prospecting);
            writer.WriteByte(regenRate);
            writer.WriteVarShort((int)initiative);
            writer.WriteSByte(alignmentSide);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteVarShort((int)subAreaId);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            writer.WriteShort((short)companions.Count());
            foreach (var entry in companions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            lifePoints = reader.ReadVarUhInt();
            maxLifePoints = reader.ReadVarUhInt();
            prospecting = reader.ReadVarUhShort();
            regenRate = reader.ReadByte();
            initiative = reader.ReadVarUhShort();
            alignmentSide = reader.ReadSByte();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadInt();
            subAreaId = reader.ReadVarUhShort();
            status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadUShort());
            status.Deserialize(reader);
            var limit = reader.ReadUShort();
            companions = new Types.PartyCompanionMemberInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (companions as Types.PartyCompanionMemberInformations[])[i] = new Types.PartyCompanionMemberInformations();
                 (companions as Types.PartyCompanionMemberInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}