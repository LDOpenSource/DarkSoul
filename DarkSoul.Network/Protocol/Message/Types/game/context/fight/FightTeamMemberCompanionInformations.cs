

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightTeamMemberCompanionInformations : FightTeamMemberInformations
    {
        public override short TypeId => 451;
        
        public sbyte companionId;
        public byte level;
        public double masterId;
        
        public FightTeamMemberCompanionInformations()
        {
        }
        
        public FightTeamMemberCompanionInformations(double id, sbyte companionId, byte level, double masterId)
         : base(id)
        {
            this.companionId = companionId;
            this.level = level;
            this.masterId = masterId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(companionId);
            writer.WriteByte(level);
            writer.WriteDouble(masterId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            companionId = reader.ReadSByte();
            level = reader.ReadByte();
            masterId = reader.ReadDouble();
        }
        
    }
    
}