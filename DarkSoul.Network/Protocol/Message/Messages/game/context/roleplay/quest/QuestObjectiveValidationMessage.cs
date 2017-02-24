

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
    public class QuestObjectiveValidationMessage : NetworkMessage
    {
        public override ushort Id => 6085;
        
        
        public ushort questId;
        public ushort objectiveId;
        
        public QuestObjectiveValidationMessage()
        {
        }
        
        public QuestObjectiveValidationMessage(ushort questId, ushort objectiveId)
        {
            this.questId = questId;
            this.objectiveId = objectiveId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)questId);
            writer.WriteVarShort((int)objectiveId);
        }
        
        public override void Deserialize(IReader reader)
        {
            questId = reader.ReadVarUhShort();
            objectiveId = reader.ReadVarUhShort();
        }
        
    }
    
}