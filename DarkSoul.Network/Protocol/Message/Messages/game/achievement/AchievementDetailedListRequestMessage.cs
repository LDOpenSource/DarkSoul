

// Generated on 02/23/2017 16:53:17
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AchievementDetailedListRequestMessage : NetworkMessage
    {
        public override ushort Id => 6357;
        
        
        public ushort categoryId;
        
        public AchievementDetailedListRequestMessage()
        {
        }
        
        public AchievementDetailedListRequestMessage(ushort categoryId)
        {
            this.categoryId = categoryId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)categoryId);
        }
        
        public override void Deserialize(IReader reader)
        {
            categoryId = reader.ReadVarUhShort();
        }
        
    }
    
}