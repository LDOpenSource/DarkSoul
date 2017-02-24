

// Generated on 02/23/2017 16:53:57
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeObjectModifiedMessage : ExchangeObjectMessage
    {
        public override ushort Id => 5519;
        
        
        public Types.ObjectItem @object;
        
        public ExchangeObjectModifiedMessage()
        {
        }
        
        public ExchangeObjectModifiedMessage(bool remote, Types.ObjectItem @object)
         : base(remote)
        {
            this.@object = @object;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            @object.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            @object = new Types.ObjectItem();
            @object.Deserialize(reader);
        }
        
    }
    
}