

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class Idol
    {
        public virtual short TypeId => 489;
        
        public ushort id;
        public ushort xpBonusPercent;
        public ushort dropBonusPercent;
        
        public Idol()
        {
        }
        
        public Idol(ushort id, ushort xpBonusPercent, ushort dropBonusPercent)
        {
            this.id = id;
            this.xpBonusPercent = xpBonusPercent;
            this.dropBonusPercent = dropBonusPercent;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)id);
            writer.WriteVarShort((int)xpBonusPercent);
            writer.WriteVarShort((int)dropBonusPercent);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            id = reader.ReadVarUhShort();
            xpBonusPercent = reader.ReadVarUhShort();
            dropBonusPercent = reader.ReadVarUhShort();
        }
        
    }
    
}