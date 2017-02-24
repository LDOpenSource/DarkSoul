

// Generated on 02/23/2017 16:53:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PurchasableDialogMessage : NetworkMessage
    {
        public override ushort Id => 5739;
        
        
        public bool buyOrSell;
        public bool secondHand;
        public uint purchasableId;
        public uint purchasableInstanceId;
        public double price;
        
        public PurchasableDialogMessage()
        {
        }
        
        public PurchasableDialogMessage(bool buyOrSell, bool secondHand, uint purchasableId, uint purchasableInstanceId, double price)
        {
            this.buyOrSell = buyOrSell;
            this.secondHand = secondHand;
            this.purchasableId = purchasableId;
            this.purchasableInstanceId = purchasableInstanceId;
            this.price = price;
        }
        
        public override void Serialize(IWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, buyOrSell);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, secondHand);
            writer.WriteByte(flag1);
            writer.WriteVarInt((int)purchasableId);
            writer.WriteUInt(purchasableInstanceId);
            writer.WriteVarLong(price);
        }
        
        public override void Deserialize(IReader reader)
        {
            byte flag1 = reader.ReadByte();
            buyOrSell = BooleanByteWrapper.GetFlag(flag1, 0);
            secondHand = BooleanByteWrapper.GetFlag(flag1, 1);
            purchasableId = reader.ReadVarUhInt();
            purchasableInstanceId = reader.ReadUInt();
            price = reader.ReadVarUhLong();
        }
        
    }
    
}