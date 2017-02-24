

// Generated on 02/23/2017 16:53:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class HavenBagPermissionsUpdateRequestMessage : NetworkMessage
    {
        public override ushort Id => 6714;
        
        
        public int permissions;
        
        public HavenBagPermissionsUpdateRequestMessage()
        {
        }
        
        public HavenBagPermissionsUpdateRequestMessage(int permissions)
        {
            this.permissions = permissions;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(permissions);
        }
        
        public override void Deserialize(IReader reader)
        {
            permissions = reader.ReadInt();
        }
        
    }
    
}