

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class QuestActiveInformations
    {
        public virtual short TypeId => 381;
        
        public ushort questId;
        
        public QuestActiveInformations()
        {
        }
        
        public QuestActiveInformations(ushort questId)
        {
            this.questId = questId;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)questId);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            questId = reader.ReadVarUhShort();
        }
        
    }
    
}