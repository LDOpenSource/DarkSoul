

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameContextActorInformations
    {
        public virtual short TypeId => 150;
        
        public double contextualId;
        public Types.EntityLook look;
        public Types.EntityDispositionInformations disposition;
        
        public GameContextActorInformations()
        {
        }
        
        public GameContextActorInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition)
        {
            this.contextualId = contextualId;
            this.look = look;
            this.disposition = disposition;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteDouble(contextualId);
            look.Serialize(writer);
            writer.WriteShort(disposition.TypeId);
            disposition.Serialize(writer);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            contextualId = reader.ReadDouble();
            look = new Types.EntityLook();
            look.Deserialize(reader);
            disposition = ProtocolTypeManager.GetInstance<Types.EntityDispositionInformations>(reader.ReadUShort());
            disposition.Deserialize(reader);
        }
        
    }
    
}