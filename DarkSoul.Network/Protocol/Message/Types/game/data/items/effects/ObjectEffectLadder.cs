

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectEffectLadder : ObjectEffectCreature
    {
        public override short TypeId => 81;
        
        public uint monsterCount;
        
        public ObjectEffectLadder()
        {
        }
        
        public ObjectEffectLadder(ushort actionId, ushort monsterFamilyId, uint monsterCount)
         : base(actionId, monsterFamilyId)
        {
            this.monsterCount = monsterCount;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)monsterCount);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            monsterCount = reader.ReadVarUhInt();
        }
        
    }
    
}