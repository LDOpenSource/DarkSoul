

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameRolePlayNpcQuestFlag
    {
        public virtual short TypeId => 384;
        
        public IEnumerable<ushort> questsToValidId;
        public IEnumerable<ushort> questsToStartId;
        
        public GameRolePlayNpcQuestFlag()
        {
        }
        
        public GameRolePlayNpcQuestFlag(IEnumerable<ushort> questsToValidId, IEnumerable<ushort> questsToStartId)
        {
            this.questsToValidId = questsToValidId;
            this.questsToStartId = questsToStartId;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteShort((short)questsToValidId.Count());
            foreach (var entry in questsToValidId)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)questsToStartId.Count());
            foreach (var entry in questsToStartId)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            questsToValidId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (questsToValidId as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            questsToStartId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (questsToStartId as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}