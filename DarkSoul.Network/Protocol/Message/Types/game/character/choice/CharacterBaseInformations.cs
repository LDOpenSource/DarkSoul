

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class CharacterBaseInformations : CharacterMinimalPlusLookInformations
    {
        public override short TypeId => 45;
        
        public sbyte breed;
        public bool sex;
        
        public CharacterBaseInformations()
        {
        }
        
        public CharacterBaseInformations(double id, string name, byte level, Types.EntityLook entityLook, sbyte breed, bool sex)
         : base(id, name, level, entityLook)
        {
            this.breed = breed;
            this.sex = sex;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
        }
        
    }
    
}