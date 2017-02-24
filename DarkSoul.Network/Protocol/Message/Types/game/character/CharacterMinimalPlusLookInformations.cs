

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class CharacterMinimalPlusLookInformations : CharacterMinimalInformations
    {
        public override short TypeId => 163;
        
        public Types.EntityLook entityLook;
        
        public CharacterMinimalPlusLookInformations()
        {
        }
        
        public CharacterMinimalPlusLookInformations(double id, string name, byte level, Types.EntityLook entityLook)
         : base(id, name, level)
        {
            this.entityLook = entityLook;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            entityLook.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
        }
        
    }
    
}