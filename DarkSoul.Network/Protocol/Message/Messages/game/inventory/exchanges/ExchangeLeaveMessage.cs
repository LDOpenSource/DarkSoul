

// Generated on 02/23/2017 16:53:53
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeLeaveMessage : LeaveDialogMessage
    {
        public override ushort Id => 5628;
        
        
        public bool success;
        
        public ExchangeLeaveMessage()
        {
        }
        
        public ExchangeLeaveMessage(sbyte dialogType, bool success)
         : base(dialogType)
        {
            this.success = success;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(success);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            success = reader.ReadBoolean();
        }
        
    }
    
}