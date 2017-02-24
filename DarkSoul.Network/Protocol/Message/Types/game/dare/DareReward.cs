

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class DareReward
    {
        public virtual short TypeId => 505;
        
        public sbyte type;
        public ushort monsterId;
        public double kamas;
        public double dareId;
        
        public DareReward()
        {
        }
        
        public DareReward(sbyte type, ushort monsterId, double kamas, double dareId)
        {
            this.type = type;
            this.monsterId = monsterId;
            this.kamas = kamas;
            this.dareId = dareId;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(type);
            writer.WriteVarShort((int)monsterId);
            writer.WriteVarLong(kamas);
            writer.WriteDouble(dareId);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            type = reader.ReadSByte();
            monsterId = reader.ReadVarUhShort();
            kamas = reader.ReadVarUhLong();
            dareId = reader.ReadDouble();
        }
        
    }
    
}