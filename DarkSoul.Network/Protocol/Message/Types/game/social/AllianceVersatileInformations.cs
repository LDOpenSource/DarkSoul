

// Generated on 02/23/2017 18:06:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AllianceVersatileInformations
    {
        public virtual short TypeId => 432;
        
        public uint allianceId;
        public ushort nbGuilds;
        public ushort nbMembers;
        public ushort nbSubarea;
        
        public AllianceVersatileInformations()
        {
        }
        
        public AllianceVersatileInformations(uint allianceId, ushort nbGuilds, ushort nbMembers, ushort nbSubarea)
        {
            this.allianceId = allianceId;
            this.nbGuilds = nbGuilds;
            this.nbMembers = nbMembers;
            this.nbSubarea = nbSubarea;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)allianceId);
            writer.WriteVarShort((int)nbGuilds);
            writer.WriteVarShort((int)nbMembers);
            writer.WriteVarShort((int)nbSubarea);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            allianceId = reader.ReadVarUhInt();
            nbGuilds = reader.ReadVarUhShort();
            nbMembers = reader.ReadVarUhShort();
            nbSubarea = reader.ReadVarUhShort();
        }
        
    }
    
}