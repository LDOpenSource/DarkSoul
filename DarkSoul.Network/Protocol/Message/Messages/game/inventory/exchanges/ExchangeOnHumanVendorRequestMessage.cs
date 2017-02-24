

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
    public class ExchangeOnHumanVendorRequestMessage : NetworkMessage
    {
        public override ushort Id => 5772;
        
        
        public double humanVendorId;
        public ushort humanVendorCell;
        
        public ExchangeOnHumanVendorRequestMessage()
        {
        }
        
        public ExchangeOnHumanVendorRequestMessage(double humanVendorId, ushort humanVendorCell)
        {
            this.humanVendorId = humanVendorId;
            this.humanVendorCell = humanVendorCell;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(humanVendorId);
            writer.WriteVarShort((int)humanVendorCell);
        }
        
        public override void Deserialize(IReader reader)
        {
            humanVendorId = reader.ReadVarUhLong();
            humanVendorCell = reader.ReadVarUhShort();
        }
        
    }
    
}