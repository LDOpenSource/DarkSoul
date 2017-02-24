

// Generated on 02/23/2017 16:53:57
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GoldAddedMessage : NetworkMessage
    {
        public override ushort Id => 6030;
        
        
        public Types.GoldItem gold;
        
        public GoldAddedMessage()
        {
        }
        
        public GoldAddedMessage(Types.GoldItem gold)
        {
            this.gold = gold;
        }
        
        public override void Serialize(IWriter writer)
        {
            gold.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            gold = new Types.GoldItem();
            gold.Deserialize(reader);
        }
        
    }
    
}