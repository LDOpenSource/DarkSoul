

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class MountInformationsForPaddock
    {
        public virtual short TypeId => 184;
        
        public ushort modelId;
        public string name;
        public string ownerName;
        
        public MountInformationsForPaddock()
        {
        }
        
        public MountInformationsForPaddock(ushort modelId, string name, string ownerName)
        {
            this.modelId = modelId;
            this.name = name;
            this.ownerName = ownerName;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)modelId);
            writer.WriteUTF(name);
            writer.WriteUTF(ownerName);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            modelId = reader.ReadVarUhShort();
            name = reader.ReadUTF();
            ownerName = reader.ReadUTF();
        }
        
    }
    
}