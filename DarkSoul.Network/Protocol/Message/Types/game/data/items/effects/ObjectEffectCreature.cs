

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectEffectCreature : ObjectEffect
    {
        public override short TypeId => 71;
        
        public ushort monsterFamilyId;
        
        public ObjectEffectCreature()
        {
        }
        
        public ObjectEffectCreature(ushort actionId, ushort monsterFamilyId)
         : base(actionId)
        {
            this.monsterFamilyId = monsterFamilyId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)monsterFamilyId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            monsterFamilyId = reader.ReadVarUhShort();
        }
        
    }
    
}