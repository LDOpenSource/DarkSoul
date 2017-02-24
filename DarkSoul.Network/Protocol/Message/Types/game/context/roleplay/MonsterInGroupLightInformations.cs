

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class MonsterInGroupLightInformations
    {
        public virtual short TypeId => 395;
        
        public int creatureGenericId;
        public sbyte grade;
        
        public MonsterInGroupLightInformations()
        {
        }
        
        public MonsterInGroupLightInformations(int creatureGenericId, sbyte grade)
        {
            this.creatureGenericId = creatureGenericId;
            this.grade = grade;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(creatureGenericId);
            writer.WriteSByte(grade);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            creatureGenericId = reader.ReadInt();
            grade = reader.ReadSByte();
        }
        
    }
    
}