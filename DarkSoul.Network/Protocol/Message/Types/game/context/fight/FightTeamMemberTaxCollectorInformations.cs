

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightTeamMemberTaxCollectorInformations : FightTeamMemberInformations
    {
        public override short TypeId => 177;
        
        public ushort firstNameId;
        public ushort lastNameId;
        public byte level;
        public uint guildId;
        public uint uid;
        
        public FightTeamMemberTaxCollectorInformations()
        {
        }
        
        public FightTeamMemberTaxCollectorInformations(double id, ushort firstNameId, ushort lastNameId, byte level, uint guildId, uint uid)
         : base(id)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.level = level;
            this.guildId = guildId;
            this.uid = uid;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)firstNameId);
            writer.WriteVarShort((int)lastNameId);
            writer.WriteByte(level);
            writer.WriteVarInt((int)guildId);
            writer.WriteVarInt((int)uid);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            firstNameId = reader.ReadVarUhShort();
            lastNameId = reader.ReadVarUhShort();
            level = reader.ReadByte();
            guildId = reader.ReadVarUhInt();
            uid = reader.ReadVarUhInt();
        }
        
    }
    
}