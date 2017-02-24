

// Generated on 02/23/2017 16:53:16
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class IdentificationFailedBannedMessage : IdentificationFailedMessage
    {
        public override ushort Id => 6174;
        
        
        public double banEndDate;
        
        public IdentificationFailedBannedMessage()
        {
        }
        
        public IdentificationFailedBannedMessage(sbyte reason, double banEndDate)
         : base(reason)
        {
            this.banEndDate = banEndDate;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(banEndDate);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            banEndDate = reader.ReadDouble();
        }
        
    }
    
}