

// Generated on 02/23/2017 16:54:04
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ProtocolRequired : NetworkMessage
    {
        public override ushort Id => 1;
        
        
        public int requiredVersion;
        public int currentVersion;
        
        public ProtocolRequired()
        {
        }
        
        public ProtocolRequired(int requiredVersion, int currentVersion)
        {
            this.requiredVersion = requiredVersion;
            this.currentVersion = currentVersion;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(requiredVersion);
            writer.WriteInt(currentVersion);
        }
        
        public override void Deserialize(IReader reader)
        {
            requiredVersion = reader.ReadInt();
            currentVersion = reader.ReadInt();
        }
        
    }
    
}