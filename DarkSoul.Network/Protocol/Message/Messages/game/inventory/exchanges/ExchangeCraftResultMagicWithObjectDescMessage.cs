

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
    public class ExchangeCraftResultMagicWithObjectDescMessage : ExchangeCraftResultWithObjectDescMessage
    {
        public override ushort Id => 6188;
        
        
        public sbyte magicPoolStatus;
        
        public ExchangeCraftResultMagicWithObjectDescMessage()
        {
        }
        
        public ExchangeCraftResultMagicWithObjectDescMessage(sbyte craftResult, Types.ObjectItemNotInContainer objectInfo, sbyte magicPoolStatus)
         : base(craftResult, objectInfo)
        {
            this.magicPoolStatus = magicPoolStatus;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(magicPoolStatus);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            magicPoolStatus = reader.ReadSByte();
        }
        
    }
    
}