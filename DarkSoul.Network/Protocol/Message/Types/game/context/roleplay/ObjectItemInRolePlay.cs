

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectItemInRolePlay
    {
        public virtual short TypeId => 198;
        
        public ushort cellId;
        public ushort objectGID;
        
        public ObjectItemInRolePlay()
        {
        }
        
        public ObjectItemInRolePlay(ushort cellId, ushort objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)cellId);
            writer.WriteVarShort((int)objectGID);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            cellId = reader.ReadVarUhShort();
            objectGID = reader.ReadVarUhShort();
        }
        
    }
    
}