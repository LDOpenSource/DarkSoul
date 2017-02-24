

// Generated on 02/23/2017 16:53:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PaddockSellBuyDialogMessage : NetworkMessage
    {
        public override ushort Id => 6018;
        
        
        public bool bsell;
        public uint ownerId;
        public double price;
        
        public PaddockSellBuyDialogMessage()
        {
        }
        
        public PaddockSellBuyDialogMessage(bool bsell, uint ownerId, double price)
        {
            this.bsell = bsell;
            this.ownerId = ownerId;
            this.price = price;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(bsell);
            writer.WriteVarInt((int)ownerId);
            writer.WriteVarLong(price);
        }
        
        public override void Deserialize(IReader reader)
        {
            bsell = reader.ReadBoolean();
            ownerId = reader.ReadVarUhInt();
            price = reader.ReadVarUhLong();
        }
        
    }
    
}