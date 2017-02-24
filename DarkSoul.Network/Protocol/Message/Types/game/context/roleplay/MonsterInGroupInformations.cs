

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class MonsterInGroupInformations : MonsterInGroupLightInformations
    {
        public override short TypeId => 144;
        
        public Types.EntityLook look;
        
        public MonsterInGroupInformations()
        {
        }
        
        public MonsterInGroupInformations(int creatureGenericId, sbyte grade, Types.EntityLook look)
         : base(creatureGenericId, grade)
        {
            this.look = look;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            look.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            look = new Types.EntityLook();
            look.Deserialize(reader);
        }
        
    }
    
}