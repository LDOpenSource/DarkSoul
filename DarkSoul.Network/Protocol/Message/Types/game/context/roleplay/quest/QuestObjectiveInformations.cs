

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class QuestObjectiveInformations
    {
        public virtual short TypeId => 385;
        
        public ushort objectiveId;
        public bool objectiveStatus;
        public IEnumerable<string> dialogParams;
        
        public QuestObjectiveInformations()
        {
        }
        
        public QuestObjectiveInformations(ushort objectiveId, bool objectiveStatus, IEnumerable<string> dialogParams)
        {
            this.objectiveId = objectiveId;
            this.objectiveStatus = objectiveStatus;
            this.dialogParams = dialogParams;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)objectiveId);
            writer.WriteBoolean(objectiveStatus);
            writer.WriteShort((short)dialogParams.Count());
            foreach (var entry in dialogParams)
            {
                 writer.WriteUTF(entry);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            objectiveId = reader.ReadVarUhShort();
            objectiveStatus = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            dialogParams = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 (dialogParams as string[])[i] = reader.ReadUTF();
            }
        }
        
    }
    
}