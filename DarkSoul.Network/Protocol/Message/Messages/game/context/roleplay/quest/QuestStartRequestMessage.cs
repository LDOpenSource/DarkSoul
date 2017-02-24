

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
    public class QuestStartRequestMessage : NetworkMessage
    {
        public override ushort Id => 5643;
        
        
        public ushort questId;
        
        public QuestStartRequestMessage()
        {
        }
        
        public QuestStartRequestMessage(ushort questId)
        {
            this.questId = questId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)questId);
        }
        
        public override void Deserialize(IReader reader)
        {
            questId = reader.ReadVarUhShort();
        }
        
    }
    
}