

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
    public class TreasureHuntRequestAnswerMessage : NetworkMessage
    {
        public override ushort Id => 6489;
        
        
        public sbyte questType;
        public sbyte result;
        
        public TreasureHuntRequestAnswerMessage()
        {
        }
        
        public TreasureHuntRequestAnswerMessage(sbyte questType, sbyte result)
        {
            this.questType = questType;
            this.result = result;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(questType);
            writer.WriteSByte(result);
        }
        
        public override void Deserialize(IReader reader)
        {
            questType = reader.ReadSByte();
            result = reader.ReadSByte();
        }
        
    }
    
}