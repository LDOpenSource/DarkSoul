

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HavenBagFurnitureInformation
    {
        public virtual short TypeId => 498;
        
        public ushort cellId;
        public int funitureId;
        public sbyte orientation;
        
        public HavenBagFurnitureInformation()
        {
        }
        
        public HavenBagFurnitureInformation(ushort cellId, int funitureId, sbyte orientation)
        {
            this.cellId = cellId;
            this.funitureId = funitureId;
            this.orientation = orientation;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)cellId);
            writer.WriteInt(funitureId);
            writer.WriteSByte(orientation);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            cellId = reader.ReadVarUhShort();
            funitureId = reader.ReadInt();
            orientation = reader.ReadSByte();
        }
        
    }
    
}