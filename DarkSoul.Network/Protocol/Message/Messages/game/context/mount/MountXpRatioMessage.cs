

// Generated on 02/23/2017 16:53:33
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MountXpRatioMessage : NetworkMessage
    {
        public override ushort Id => 5970;
        
        
        public sbyte ratio;
        
        public MountXpRatioMessage()
        {
        }
        
        public MountXpRatioMessage(sbyte ratio)
        {
            this.ratio = ratio;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(ratio);
        }
        
        public override void Deserialize(IReader reader)
        {
            ratio = reader.ReadSByte();
        }
        
    }
    
}