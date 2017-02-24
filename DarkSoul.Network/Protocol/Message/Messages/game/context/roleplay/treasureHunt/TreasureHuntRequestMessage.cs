

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
    public class TreasureHuntRequestMessage : NetworkMessage
    {
        public override ushort Id => 6488;
        
        
        public byte questLevel;
        public sbyte questType;
        
        public TreasureHuntRequestMessage()
        {
        }
        
        public TreasureHuntRequestMessage(byte questLevel, sbyte questType)
        {
            this.questLevel = questLevel;
            this.questType = questType;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteByte(questLevel);
            writer.WriteSByte(questType);
        }
        
        public override void Deserialize(IReader reader)
        {
            questLevel = reader.ReadByte();
            questType = reader.ReadSByte();
        }
        
    }
    
}