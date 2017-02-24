

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class MonsterBoosts
    {
        public virtual short TypeId => 497;
        
        public uint id;
        public ushort xpBoost;
        public ushort dropBoost;
        
        public MonsterBoosts()
        {
        }
        
        public MonsterBoosts(uint id, ushort xpBoost, ushort dropBoost)
        {
            this.id = id;
            this.xpBoost = xpBoost;
            this.dropBoost = dropBoost;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)id);
            writer.WriteVarShort((int)xpBoost);
            writer.WriteVarShort((int)dropBoost);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            id = reader.ReadVarUhInt();
            xpBoost = reader.ReadVarUhShort();
            dropBoost = reader.ReadVarUhShort();
        }
        
    }
    
}