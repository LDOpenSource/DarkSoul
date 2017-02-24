

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PartyCompanionBaseInformations
    {
        public virtual short TypeId => 453;
        
        public sbyte indexId;
        public sbyte companionGenericId;
        public Types.EntityLook entityLook;
        
        public PartyCompanionBaseInformations()
        {
        }
        
        public PartyCompanionBaseInformations(sbyte indexId, sbyte companionGenericId, Types.EntityLook entityLook)
        {
            this.indexId = indexId;
            this.companionGenericId = companionGenericId;
            this.entityLook = entityLook;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(indexId);
            writer.WriteSByte(companionGenericId);
            entityLook.Serialize(writer);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            indexId = reader.ReadSByte();
            companionGenericId = reader.ReadSByte();
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
        }
        
    }
    
}