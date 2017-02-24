

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class CharacterMinimalPlusLookAndGradeInformations : CharacterMinimalPlusLookInformations
    {
        public override short TypeId => 193;
        
        public uint grade;
        
        public CharacterMinimalPlusLookAndGradeInformations()
        {
        }
        
        public CharacterMinimalPlusLookAndGradeInformations(double id, string name, byte level, Types.EntityLook entityLook, uint grade)
         : base(id, name, level, entityLook)
        {
            this.grade = grade;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)grade);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            grade = reader.ReadVarUhInt();
        }
        
    }
    
}