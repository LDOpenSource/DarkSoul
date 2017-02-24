

// Generated on 02/23/2017 16:53:52
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeCrafterJobLevelupMessage : NetworkMessage
    {
        public override ushort Id => 6598;
        
        
        public byte crafterJobLevel;
        
        public ExchangeCrafterJobLevelupMessage()
        {
        }
        
        public ExchangeCrafterJobLevelupMessage(byte crafterJobLevel)
        {
            this.crafterJobLevel = crafterJobLevel;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteByte(crafterJobLevel);
        }
        
        public override void Deserialize(IReader reader)
        {
            crafterJobLevel = reader.ReadByte();
        }
        
    }
    
}