

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
    public class TreasureHuntDigRequestAnswerFailedMessage : TreasureHuntDigRequestAnswerMessage
    {
        public override ushort Id => 6509;
        
        
        public sbyte wrongFlagCount;
        
        public TreasureHuntDigRequestAnswerFailedMessage()
        {
        }
        
        public TreasureHuntDigRequestAnswerFailedMessage(sbyte questType, sbyte result, sbyte wrongFlagCount)
         : base(questType, result)
        {
            this.wrongFlagCount = wrongFlagCount;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(wrongFlagCount);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            wrongFlagCount = reader.ReadSByte();
        }
        
    }
    
}