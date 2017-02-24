

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HumanInformations
    {
        public virtual short TypeId => 157;
        
        public Types.ActorRestrictionsInformations restrictions;
        public bool sex;
        public IEnumerable<Types.HumanOption> options;
        
        public HumanInformations()
        {
        }
        
        public HumanInformations(Types.ActorRestrictionsInformations restrictions, bool sex, IEnumerable<Types.HumanOption> options)
        {
            this.restrictions = restrictions;
            this.sex = sex;
            this.options = options;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            restrictions.Serialize(writer);
            writer.WriteBoolean(sex);
            writer.WriteShort((short)options.Count());
            foreach (var entry in options)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            restrictions = new Types.ActorRestrictionsInformations();
            restrictions.Deserialize(reader);
            sex = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            options = new Types.HumanOption[limit];
            for (int i = 0; i < limit; i++)
            {
                 (options as Types.HumanOption[])[i] = ProtocolTypeManager.GetInstance<Types.HumanOption>(reader.ReadUShort());
                 (options as Types.HumanOption[])[i].Deserialize(reader);
            }
        }
        
    }
    
}