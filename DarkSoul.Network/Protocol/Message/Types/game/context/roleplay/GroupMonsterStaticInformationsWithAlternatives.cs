

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GroupMonsterStaticInformationsWithAlternatives : GroupMonsterStaticInformations
    {
        public override short TypeId => 396;
        
        public IEnumerable<Types.AlternativeMonstersInGroupLightInformations> alternatives;
        
        public GroupMonsterStaticInformationsWithAlternatives()
        {
        }
        
        public GroupMonsterStaticInformationsWithAlternatives(Types.MonsterInGroupLightInformations mainCreatureLightInfos, IEnumerable<Types.MonsterInGroupInformations> underlings, IEnumerable<Types.AlternativeMonstersInGroupLightInformations> alternatives)
         : base(mainCreatureLightInfos, underlings)
        {
            this.alternatives = alternatives;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)alternatives.Count());
            foreach (var entry in alternatives)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            alternatives = new Types.AlternativeMonstersInGroupLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (alternatives as Types.AlternativeMonstersInGroupLightInformations[])[i] = new Types.AlternativeMonstersInGroupLightInformations();
                 (alternatives as Types.AlternativeMonstersInGroupLightInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}