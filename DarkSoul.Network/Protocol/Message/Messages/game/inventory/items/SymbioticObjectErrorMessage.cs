

// Generated on 02/23/2017 16:53:59
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SymbioticObjectErrorMessage : ObjectErrorMessage
    {
        public override ushort Id => 6526;
        
        
        public sbyte errorCode;
        
        public SymbioticObjectErrorMessage()
        {
        }
        
        public SymbioticObjectErrorMessage(sbyte reason, sbyte errorCode)
         : base(reason)
        {
            this.errorCode = errorCode;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(errorCode);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            errorCode = reader.ReadSByte();
        }
        
    }
    
}