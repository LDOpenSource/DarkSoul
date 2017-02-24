

// Generated on 02/23/2017 16:53:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class QuestListMessage : NetworkMessage
    {
        public override ushort Id => 5626;
        
        
        public IEnumerable<ushort> finishedQuestsIds;
        public IEnumerable<ushort> finishedQuestsCounts;
        public IEnumerable<Types.QuestActiveInformations> activeQuests;
        public IEnumerable<ushort> reinitDoneQuestsIds;
        
        public QuestListMessage()
        {
        }
        
        public QuestListMessage(IEnumerable<ushort> finishedQuestsIds, IEnumerable<ushort> finishedQuestsCounts, IEnumerable<Types.QuestActiveInformations> activeQuests, IEnumerable<ushort> reinitDoneQuestsIds)
        {
            this.finishedQuestsIds = finishedQuestsIds;
            this.finishedQuestsCounts = finishedQuestsCounts;
            this.activeQuests = activeQuests;
            this.reinitDoneQuestsIds = reinitDoneQuestsIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)finishedQuestsIds.Count());
            foreach (var entry in finishedQuestsIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)finishedQuestsCounts.Count());
            foreach (var entry in finishedQuestsCounts)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)activeQuests.Count());
            foreach (var entry in activeQuests)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)reinitDoneQuestsIds.Count());
            foreach (var entry in reinitDoneQuestsIds)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            finishedQuestsIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (finishedQuestsIds as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            finishedQuestsCounts = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (finishedQuestsCounts as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            activeQuests = new Types.QuestActiveInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (activeQuests as Types.QuestActiveInformations[])[i] = ProtocolTypeManager.GetInstance<Types.QuestActiveInformations>(reader.ReadUShort());
                 (activeQuests as Types.QuestActiveInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            reinitDoneQuestsIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (reinitDoneQuestsIds as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}