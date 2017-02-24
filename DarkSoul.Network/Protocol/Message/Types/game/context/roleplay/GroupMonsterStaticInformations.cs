

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GroupMonsterStaticInformations
    {
        public virtual short TypeId => 140;
        
        public Types.MonsterInGroupLightInformations mainCreatureLightInfos;
        public IEnumerable<Types.MonsterInGroupInformations> underlings;
        
        public GroupMonsterStaticInformations()
        {
        }
        
        public GroupMonsterStaticInformations(Types.MonsterInGroupLightInformations mainCreatureLightInfos, IEnumerable<Types.MonsterInGroupInformations> underlings)
        {
            this.mainCreatureLightInfos = mainCreatureLightInfos;
            this.underlings = underlings;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            mainCreatureLightInfos.Serialize(writer);
            writer.WriteShort((short)underlings.Count());
            foreach (var entry in underlings)
            {
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            mainCreatureLightInfos = new Types.MonsterInGroupLightInformations();
            mainCreatureLightInfos.Deserialize(reader);
            var limit = reader.ReadUShort();
            underlings = new Types.MonsterInGroupInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (underlings as Types.MonsterInGroupInformations[])[i] = new Types.MonsterInGroupInformations();
                 (underlings as Types.MonsterInGroupInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}