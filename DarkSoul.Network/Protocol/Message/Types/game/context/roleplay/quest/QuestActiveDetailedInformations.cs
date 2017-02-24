

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class QuestActiveDetailedInformations : QuestActiveInformations
    {
        public override short TypeId => 382;
        
        public ushort stepId;
        public IEnumerable<Types.QuestObjectiveInformations> objectives;
        
        public QuestActiveDetailedInformations()
        {
        }
        
        public QuestActiveDetailedInformations(ushort questId, ushort stepId, IEnumerable<Types.QuestObjectiveInformations> objectives)
         : base(questId)
        {
            this.stepId = stepId;
            this.objectives = objectives;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)stepId);
            writer.WriteShort((short)objectives.Count());
            foreach (var entry in objectives)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            stepId = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            objectives = new Types.QuestObjectiveInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectives as Types.QuestObjectiveInformations[])[i] = ProtocolTypeManager.GetInstance<Types.QuestObjectiveInformations>(reader.ReadUShort());
                 (objectives as Types.QuestObjectiveInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}