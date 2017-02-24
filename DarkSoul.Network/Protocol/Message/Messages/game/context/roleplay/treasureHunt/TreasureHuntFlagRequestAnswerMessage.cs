

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
    public class TreasureHuntFlagRequestAnswerMessage : NetworkMessage
    {
        public override ushort Id => 6507;
        
        
        public sbyte questType;
        public sbyte result;
        public sbyte index;
        
        public TreasureHuntFlagRequestAnswerMessage()
        {
        }
        
        public TreasureHuntFlagRequestAnswerMessage(sbyte questType, sbyte result, sbyte index)
        {
            this.questType = questType;
            this.result = result;
            this.index = index;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(questType);
            writer.WriteSByte(result);
            writer.WriteSByte(index);
        }
        
        public override void Deserialize(IReader reader)
        {
            questType = reader.ReadSByte();
            result = reader.ReadSByte();
            index = reader.ReadSByte();
        }
        
    }
    
}