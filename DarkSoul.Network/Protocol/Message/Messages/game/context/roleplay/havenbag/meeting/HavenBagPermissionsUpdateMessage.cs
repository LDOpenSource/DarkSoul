

// Generated on 02/23/2017 16:53:36
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class HavenBagPermissionsUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6713;
        
        
        public int permissions;
        
        public HavenBagPermissionsUpdateMessage()
        {
        }
        
        public HavenBagPermissionsUpdateMessage(int permissions)
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