

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
    public class IdentificationFailedForBadVersionMessage : IdentificationFailedMessage
    {
        public override ushort Id => 21;
        
        
        public Types.Version requiredVersion;
        
        public IdentificationFailedForBadVersionMessage()
        {
        }
        
        public IdentificationFailedForBadVersionMessage(sbyte reason, Types.Version requiredVersion)
         : base(reason)
        {
            this.requiredVersion = requiredVersion;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            requiredVersion.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            requiredVersion = new Types.Version();
            requiredVersion.Deserialize(reader);
        }
        
    }
    
}