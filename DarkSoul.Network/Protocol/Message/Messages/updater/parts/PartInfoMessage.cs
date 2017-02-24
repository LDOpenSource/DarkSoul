

// Generated on 02/23/2017 16:54:05
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PartInfoMessage : NetworkMessage
    {
        public override ushort Id => 1508;
        
        
        public Types.ContentPart part;
        public float installationPercent;
        
        public PartInfoMessage()
        {
        }
        
        public PartInfoMessage(Types.ContentPart part, float installationPercent)
        {
            this.part = part;
            this.installationPercent = installationPercent;
        }
        
        public override void Serialize(IWriter writer)
        {
            part.Serialize(writer);
            writer.WriteFloat(installationPercent);
        }
        
        public override void Deserialize(IReader reader)
        {
            part = new Types.ContentPart();
            part.Deserialize(reader);
            installationPercent = reader.ReadFloat();
        }
        
    }
    
}