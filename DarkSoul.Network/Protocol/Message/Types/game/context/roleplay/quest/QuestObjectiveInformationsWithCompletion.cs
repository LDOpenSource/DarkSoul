

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class QuestObjectiveInformationsWithCompletion : QuestObjectiveInformations
    {
        public override short TypeId => 386;
        
        public ushort curCompletion;
        public ushort maxCompletion;
        
        public QuestObjectiveInformationsWithCompletion()
        {
        }
        
        public QuestObjectiveInformationsWithCompletion(ushort objectiveId, bool objectiveStatus, IEnumerable<string> dialogParams, ushort curCompletion, ushort maxCompletion)
         : base(objectiveId, objectiveStatus, dialogParams)
        {
            this.curCompletion = curCompletion;
            this.maxCompletion = maxCompletion;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)curCompletion);
            writer.WriteVarShort((int)maxCompletion);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            curCompletion = reader.ReadVarUhShort();
            maxCompletion = reader.ReadVarUhShort();
        }
        
    }
    
}