

// Generated on 02/23/2017 16:53:54
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeObjectMoveMessage : NetworkMessage
    {
        public override ushort Id => 5518;
        
        
        public uint objectUID;
        public int quantity;
        
        public ExchangeObjectMoveMessage()
        {
        }
        
        public ExchangeObjectMoveMessage(uint objectUID, int quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            objectUID = reader.ReadVarUhInt();
            quantity = reader.ReadVarInt();
        }
        
    }
    
}