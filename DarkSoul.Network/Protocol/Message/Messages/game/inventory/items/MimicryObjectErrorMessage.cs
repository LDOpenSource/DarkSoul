

// Generated on 02/23/2017 16:53:58
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MimicryObjectErrorMessage : SymbioticObjectErrorMessage
    {
        public override ushort Id => 6461;
        
        
        public bool preview;
        
        public MimicryObjectErrorMessage()
        {
        }
        
        public MimicryObjectErrorMessage(sbyte reason, sbyte errorCode, bool preview)
         : base(reason, errorCode)
        {
            this.preview = preview;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(preview);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            preview = reader.ReadBoolean();
        }
        
    }
    
}