

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
    public class ExchangeBidHouseBuyMessage : NetworkMessage
    {
        public override ushort Id => 5804;
        
        
        public uint uid;
        public uint qty;
        public double price;
        
        public ExchangeBidHouseBuyMessage()
        {
        }
        
        public ExchangeBidHouseBuyMessage(uint uid, uint qty, double price)
        {
            this.uid = uid;
            this.qty = qty;
            this.price = price;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)uid);
            writer.WriteVarInt((int)qty);
            writer.WriteVarLong(price);
        }
        
        public override void Deserialize(IReader reader)
        {
            uid = reader.ReadVarUhInt();
            qty = reader.ReadVarUhInt();
            price = reader.ReadVarUhLong();
        }
        
    }
    
}