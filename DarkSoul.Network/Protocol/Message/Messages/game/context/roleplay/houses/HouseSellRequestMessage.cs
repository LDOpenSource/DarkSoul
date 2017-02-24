

// Generated on 02/23/2017 16:53:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class HouseSellRequestMessage : NetworkMessage
    {
        public override ushort Id => 5697;
        
        
        public uint instanceId;
        public double amount;
        public bool forSale;
        
        public HouseSellRequestMessage()
        {
        }
        
        public HouseSellRequestMessage(uint instanceId, double amount, bool forSale)
        {
            this.instanceId = instanceId;
            this.amount = amount;
            this.forSale = forSale;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUInt(instanceId);
            writer.WriteVarLong(amount);
            writer.WriteBoolean(forSale);
        }
        
        public override void Deserialize(IReader reader)
        {
            instanceId = reader.ReadUInt();
            amount = reader.ReadVarUhLong();
            forSale = reader.ReadBoolean();
        }
        
    }
    
}