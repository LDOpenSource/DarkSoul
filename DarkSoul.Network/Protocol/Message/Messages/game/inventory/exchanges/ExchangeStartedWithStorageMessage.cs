

// Generated on 02/23/2017 16:53:56
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeStartedWithStorageMessage : ExchangeStartedMessage
    {
        public override ushort Id => 6236;
        
        
        public uint storageMaxSlot;
        
        public ExchangeStartedWithStorageMessage()
        {
        }
        
        public ExchangeStartedWithStorageMessage(sbyte exchangeType, uint storageMaxSlot)
         : base(exchangeType)
        {
            this.storageMaxSlot = storageMaxSlot;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)storageMaxSlot);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            storageMaxSlot = reader.ReadVarUhInt();
        }
        
    }
    
}