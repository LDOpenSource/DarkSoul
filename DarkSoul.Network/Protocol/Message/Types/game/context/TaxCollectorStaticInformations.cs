

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class TaxCollectorStaticInformations
    {
        public virtual short TypeId => 147;
        
        public ushort firstNameId;
        public ushort lastNameId;
        public Types.GuildInformations guildIdentity;
        
        public TaxCollectorStaticInformations()
        {
        }
        
        public TaxCollectorStaticInformations(ushort firstNameId, ushort lastNameId, Types.GuildInformations guildIdentity)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.guildIdentity = guildIdentity;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)firstNameId);
            writer.WriteVarShort((int)lastNameId);
            guildIdentity.Serialize(writer);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            firstNameId = reader.ReadVarUhShort();
            lastNameId = reader.ReadVarUhShort();
            guildIdentity = new Types.GuildInformations();
            guildIdentity.Deserialize(reader);
        }
        
    }
    
}