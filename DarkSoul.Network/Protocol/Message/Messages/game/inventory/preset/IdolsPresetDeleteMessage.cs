

// Generated on 02/23/2017 16:53:59
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class IdolsPresetDeleteMessage : NetworkMessage
    {
        public override ushort Id => 6602;
        
        
        public sbyte presetId;
        
        public IdolsPresetDeleteMessage()
        {
        }
        
        public IdolsPresetDeleteMessage(sbyte presetId)
        {
            this.presetId = presetId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(presetId);
        }
        
        public override void Deserialize(IReader reader)
        {
            presetId = reader.ReadSByte();
        }
        
    }
    
}