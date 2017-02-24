

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PrismFightersInformation
    {
        public virtual short TypeId => 443;
        
        public ushort subAreaId;
        public Types.ProtectedEntityWaitingForHelpInfo waitingForHelpInfo;
        public IEnumerable<Types.CharacterMinimalPlusLookInformations> allyCharactersInformations;
        public IEnumerable<Types.CharacterMinimalPlusLookInformations> enemyCharactersInformations;
        
        public PrismFightersInformation()
        {
        }
        
        public PrismFightersInformation(ushort subAreaId, Types.ProtectedEntityWaitingForHelpInfo waitingForHelpInfo, IEnumerable<Types.CharacterMinimalPlusLookInformations> allyCharactersInformations, IEnumerable<Types.CharacterMinimalPlusLookInformations> enemyCharactersInformations)
        {
            this.subAreaId = subAreaId;
            this.waitingForHelpInfo = waitingForHelpInfo;
            this.allyCharactersInformations = allyCharactersInformations;
            this.enemyCharactersInformations = enemyCharactersInformations;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)subAreaId);
            waitingForHelpInfo.Serialize(writer);
            writer.WriteShort((short)allyCharactersInformations.Count());
            foreach (var entry in allyCharactersInformations)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)enemyCharactersInformations.Count());
            foreach (var entry in enemyCharactersInformations)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            subAreaId = reader.ReadVarUhShort();
            waitingForHelpInfo = new Types.ProtectedEntityWaitingForHelpInfo();
            waitingForHelpInfo.Deserialize(reader);
            var limit = reader.ReadUShort();
            allyCharactersInformations = new Types.CharacterMinimalPlusLookInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (allyCharactersInformations as Types.CharacterMinimalPlusLookInformations[])[i] = ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadUShort());
                 (allyCharactersInformations as Types.CharacterMinimalPlusLookInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            enemyCharactersInformations = new Types.CharacterMinimalPlusLookInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (enemyCharactersInformations as Types.CharacterMinimalPlusLookInformations[])[i] = ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadUShort());
                 (enemyCharactersInformations as Types.CharacterMinimalPlusLookInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}