

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HumanOptionObjectUse : HumanOption
    {
        public override short TypeId => 449;
        
        public sbyte delayTypeId;
        public double delayEndTime;
        public ushort objectGID;
        
        public HumanOptionObjectUse()
        {
        }
        
        public HumanOptionObjectUse(sbyte delayTypeId, double delayEndTime, ushort objectGID)
        {
            this.delayTypeId = delayTypeId;
            this.delayEndTime = delayEndTime;
            this.objectGID = objectGID;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(delayTypeId);
            writer.WriteDouble(delayEndTime);
            writer.WriteVarShort((int)objectGID);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            delayTypeId = reader.ReadSByte();
            delayEndTime = reader.ReadDouble();
            objectGID = reader.ReadVarUhShort();
        }
        
    }
    
}