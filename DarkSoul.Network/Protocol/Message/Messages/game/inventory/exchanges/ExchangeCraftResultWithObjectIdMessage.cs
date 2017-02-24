

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
    public class ExchangeCraftResultWithObjectIdMessage : ExchangeCraftResultMessage
    {
        public override ushort Id => 6000;
        
        
        public ushort objectGenericId;
        
        public ExchangeCraftResultWithObjectIdMessage()
        {
        }
        
        public ExchangeCraftResultWithObjectIdMessage(sbyte craftResult, ushort objectGenericId)
         : base(craftResult)
        {
            this.objectGenericId = objectGenericId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)objectGenericId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            objectGenericId = reader.ReadVarUhShort();
        }
        
    }
    
}