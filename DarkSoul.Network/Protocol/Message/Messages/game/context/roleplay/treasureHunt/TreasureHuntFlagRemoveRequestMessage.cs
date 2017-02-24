

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
    public class TreasureHuntFlagRemoveRequestMessage : NetworkMessage
    {
        public override ushort Id => 6510;
        
        
        public sbyte questType;
        public sbyte index;
        
        public TreasureHuntFlagRemoveRequestMessage()
        {
        }
        
        public TreasureHuntFlagRemoveRequestMessage(sbyte questType, sbyte index)
        {
            this.questType = questType;
            this.index = index;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(questType);
            writer.WriteSByte(index);
        }
        
        public override void Deserialize(IReader reader)
        {
            questType = reader.ReadSByte();
            index = reader.ReadSByte();
        }
        
    }
    
}