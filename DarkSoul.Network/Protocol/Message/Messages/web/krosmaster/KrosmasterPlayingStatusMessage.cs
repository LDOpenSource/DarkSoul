

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
    public class KrosmasterPlayingStatusMessage : NetworkMessage
    {
        public override ushort Id => 6347;
        
        
        public bool playing;
        
        public KrosmasterPlayingStatusMessage()
        {
        }
        
        public KrosmasterPlayingStatusMessage(bool playing)
        {
            this.playing = playing;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(playing);
        }
        
        public override void Deserialize(IReader reader)
        {
            playing = reader.ReadBoolean();
        }
        
    }
    
}