

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
    public class MimicryObjectPreviewMessage : NetworkMessage
    {
        public override ushort Id => 6458;
        
        
        public Types.ObjectItem result;
        
        public MimicryObjectPreviewMessage()
        {
        }
        
        public MimicryObjectPreviewMessage(Types.ObjectItem result)
        {
            this.result = result;
        }
        
        public override void Serialize(IWriter writer)
        {
            result.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            result = new Types.ObjectItem();
            result.Deserialize(reader);
        }
        
    }
    
}