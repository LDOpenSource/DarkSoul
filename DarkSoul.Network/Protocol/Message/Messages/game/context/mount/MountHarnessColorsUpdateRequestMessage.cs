

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
    public class MountHarnessColorsUpdateRequestMessage : NetworkMessage
    {
        public override ushort Id => 6697;
        
        
        public bool useHarnessColors;
        
        public MountHarnessColorsUpdateRequestMessage()
        {
        }
        
        public MountHarnessColorsUpdateRequestMessage(bool useHarnessColors)
        {
            this.useHarnessColors = useHarnessColors;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(useHarnessColors);
        }
        
        public override void Deserialize(IReader reader)
        {
            useHarnessColors = reader.ReadBoolean();
        }
        
    }
    
}