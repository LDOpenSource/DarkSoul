

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
    public class ChangeThemeRequestMessage : NetworkMessage
    {
        public override ushort Id => 6639;
        
        
        public sbyte theme;
        
        public ChangeThemeRequestMessage()
        {
        }
        
        public ChangeThemeRequestMessage(sbyte theme)
        {
            this.theme = theme;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(theme);
        }
        
        public override void Deserialize(IReader reader)
        {
            theme = reader.ReadSByte();
        }
        
    }
    
}