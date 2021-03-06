

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
    public class MountReleasedMessage : NetworkMessage
    {
        public override ushort Id => 6308;
        
        
        public int mountId;
        
        public MountReleasedMessage()
        {
        }
        
        public MountReleasedMessage(int mountId)
        {
            this.mountId = mountId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)mountId);
        }
        
        public override void Deserialize(IReader reader)
        {
            mountId = reader.ReadVarInt();
        }
        
    }
    
}