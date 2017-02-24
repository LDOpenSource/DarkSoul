

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PartyInvitationMemberInformations : CharacterBaseInformations
    {
        public override short TypeId => 376;
        
        public short worldX;
        public short worldY;
        public int mapId;
        public ushort subAreaId;
        public IEnumerable<Types.PartyCompanionBaseInformations> companions;
        
        public PartyInvitationMemberInformations()
        {
        }
        
        public PartyInvitationMemberInformations(double id, string name, byte level, Types.EntityLook entityLook, sbyte breed, bool sex, short worldX, short worldY, int mapId, ushort subAreaId, IEnumerable<Types.PartyCompanionBaseInformations> companions)
         : base(id, name, level, entityLook, breed, sex)
        {
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.companions = companions;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteVarShort((int)subAreaId);
            writer.WriteShort((short)companions.Count());
            foreach (var entry in companions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadInt();
            subAreaId = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            companions = new Types.PartyCompanionBaseInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (companions as Types.PartyCompanionBaseInformations[])[i] = new Types.PartyCompanionBaseInformations();
                 (companions as Types.PartyCompanionBaseInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}