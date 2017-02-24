

// Generated on 02/23/2017 16:53:32
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MountSetMessage : NetworkMessage
    {
        public override ushort Id => 5968;
        
        
        public Types.MountClientData mountData;
        
        public MountSetMessage()
        {
        }
        
        public MountSetMessage(Types.MountClientData mountData)
        {
            this.mountData = mountData;
        }
        
        public override void Serialize(IWriter writer)
        {
            mountData.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            mountData = new Types.MountClientData();
            mountData.Deserialize(reader);
        }
        
    }
    
}