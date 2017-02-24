

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
    public class MountSetXpRatioRequestMessage : NetworkMessage
    {
        public override ushort Id => 5989;
        
        
        public sbyte xpRatio;
        
        public MountSetXpRatioRequestMessage()
        {
        }
        
        public MountSetXpRatioRequestMessage(sbyte xpRatio)
        {
            this.xpRatio = xpRatio;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(xpRatio);
        }
        
        public override void Deserialize(IReader reader)
        {
            xpRatio = reader.ReadSByte();
        }
        
    }
    
}