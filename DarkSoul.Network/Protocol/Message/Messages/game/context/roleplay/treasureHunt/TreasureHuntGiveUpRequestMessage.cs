

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
    public class TreasureHuntGiveUpRequestMessage : NetworkMessage
    {
        public override ushort Id => 6487;
        
        
        public sbyte questType;
        
        public TreasureHuntGiveUpRequestMessage()
        {
        }
        
        public TreasureHuntGiveUpRequestMessage(sbyte questType)
        {
            this.questType = questType;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(questType);
        }
        
        public override void Deserialize(IReader reader)
        {
            questType = reader.ReadSByte();
        }
        
    }
    
}