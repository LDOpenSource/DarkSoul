

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
    public class FollowedQuestsMessage : NetworkMessage
    {
        public override ushort Id => 6717;
        
        
        public IEnumerable<Types.QuestActiveDetailedInformations> quests;
        
        public FollowedQuestsMessage()
        {
        }
        
        public FollowedQuestsMessage(IEnumerable<Types.QuestActiveDetailedInformations> quests)
        {
            this.quests = quests;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)quests.Count());
            foreach (var entry in quests)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            quests = new Types.QuestActiveDetailedInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (quests as Types.QuestActiveDetailedInformations[])[i] = new Types.QuestActiveDetailedInformations();
                 (quests as Types.QuestActiveDetailedInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}