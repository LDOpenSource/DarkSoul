

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
    public class TreasureHuntAvailableRetryCountUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6491;
        
        
        public sbyte questType;
        public int availableRetryCount;
        
        public TreasureHuntAvailableRetryCountUpdateMessage()
        {
        }
        
        public TreasureHuntAvailableRetryCountUpdateMessage(sbyte questType, int availableRetryCount)
        {
            this.questType = questType;
            this.availableRetryCount = availableRetryCount;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(questType);
            writer.WriteInt(availableRetryCount);
        }
        
        public override void Deserialize(IReader reader)
        {
            questType = reader.ReadSByte();
            availableRetryCount = reader.ReadInt();
        }
        
    }
    
}