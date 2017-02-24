

// Generated on 02/23/2017 16:53:51
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeBidHouseBuyResultMessage : NetworkMessage
    {
        public override ushort Id => 6272;
        
        
        public uint uid;
        public bool bought;
        
        public ExchangeBidHouseBuyResultMessage()
        {
        }
        
        public ExchangeBidHouseBuyResultMessage(uint uid, bool bought)
        {
            this.uid = uid;
            this.bought = bought;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)uid);
            writer.WriteBoolean(bought);
        }
        
        public override void Deserialize(IReader reader)
        {
            uid = reader.ReadVarUhInt();
            bought = reader.ReadBoolean();
        }
        
    }
    
}