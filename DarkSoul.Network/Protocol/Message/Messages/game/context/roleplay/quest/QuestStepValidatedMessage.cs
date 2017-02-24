

// Generated on 02/23/2017 16:53:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class QuestStepValidatedMessage : NetworkMessage
    {
        public override ushort Id => 6099;
        
        
        public ushort questId;
        public ushort stepId;
        
        public QuestStepValidatedMessage()
        {
        }
        
        public QuestStepValidatedMessage(ushort questId, ushort stepId)
        {
            this.questId = questId;
            this.stepId = stepId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)questId);
            writer.WriteVarShort((int)stepId);
        }
        
        public override void Deserialize(IReader reader)
        {
            questId = reader.ReadVarUhShort();
            stepId = reader.ReadVarUhShort();
        }
        
    }
    
}