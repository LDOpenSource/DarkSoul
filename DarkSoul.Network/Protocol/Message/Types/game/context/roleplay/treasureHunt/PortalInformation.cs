

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PortalInformation
    {
        public virtual short TypeId => 466;
        
        public int portalId;
        public short areaId;
        
        public PortalInformation()
        {
        }
        
        public PortalInformation(int portalId, short areaId)
        {
            this.portalId = portalId;
            this.areaId = areaId;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(portalId);
            writer.WriteShort(areaId);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            portalId = reader.ReadInt();
            areaId = reader.ReadShort();
        }
        
    }
    
}