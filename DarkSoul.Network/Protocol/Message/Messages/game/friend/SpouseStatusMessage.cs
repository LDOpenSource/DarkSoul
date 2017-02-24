

// Generated on 02/23/2017 16:53:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SpouseStatusMessage : NetworkMessage
    {
        public override ushort Id => 6265;
        
        
        public bool hasSpouse;
        
        public SpouseStatusMessage()
        {
        }
        
        public SpouseStatusMessage(bool hasSpouse)
        {
            this.hasSpouse = hasSpouse;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(hasSpouse);
        }
        
        public override void Deserialize(IReader reader)
        {
            hasSpouse = reader.ReadBoolean();
        }
        
    }
    
}