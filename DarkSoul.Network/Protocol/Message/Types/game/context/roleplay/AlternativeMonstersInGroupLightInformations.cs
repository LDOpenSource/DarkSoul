

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AlternativeMonstersInGroupLightInformations
    {
        public virtual short TypeId => 394;
        
        public int playerCount;
        public IEnumerable<Types.MonsterInGroupLightInformations> monsters;
        
        public AlternativeMonstersInGroupLightInformations()
        {
        }
        
        public AlternativeMonstersInGroupLightInformations(int playerCount, IEnumerable<Types.MonsterInGroupLightInformations> monsters)
        {
            this.playerCount = playerCount;
            this.monsters = monsters;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(playerCount);
            writer.WriteShort((short)monsters.Count());
            foreach (var entry in monsters)
            {
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            playerCount = reader.ReadInt();
            var limit = reader.ReadUShort();
            monsters = new Types.MonsterInGroupLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (monsters as Types.MonsterInGroupLightInformations[])[i] = new Types.MonsterInGroupLightInformations();
                 (monsters as Types.MonsterInGroupLightInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}