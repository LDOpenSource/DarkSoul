

// Generated on 02/23/2017 16:54:00
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class IdolsPresetUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6606;
        
        
        public Types.IdolsPreset idolsPreset;
        
        public IdolsPresetUpdateMessage()
        {
        }
        
        public IdolsPresetUpdateMessage(Types.IdolsPreset idolsPreset)
        {
            this.idolsPreset = idolsPreset;
        }
        
        public override void Serialize(IWriter writer)
        {
            idolsPreset.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            idolsPreset = new Types.IdolsPreset();
            idolsPreset.Deserialize(reader);
        }
        
    }
    
}