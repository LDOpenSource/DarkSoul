

// Generated on 02/23/2017 16:53:27
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ChannelEnablingMessage : NetworkMessage
    {
        public override ushort Id => 890;
        
        
        public sbyte channel;
        public bool enable;
        
        public ChannelEnablingMessage()
        {
        }
        
        public ChannelEnablingMessage(sbyte channel, bool enable)
        {
            this.channel = channel;
            this.enable = enable;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(channel);
            writer.WriteBoolean(enable);
        }
        
        public override void Deserialize(IReader reader)
        {
            channel = reader.ReadSByte();
            enable = reader.ReadBoolean();
        }
        
    }
    
}