

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
    public class IdolsPresetSaveMessage : NetworkMessage
    {
        public override ushort Id => 6603;
        
        
        public sbyte presetId;
        public sbyte symbolId;
        
        public IdolsPresetSaveMessage()
        {
        }
        
        public IdolsPresetSaveMessage(sbyte presetId, sbyte symbolId)
        {
            this.presetId = presetId;
            this.symbolId = symbolId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(presetId);
            writer.WriteSByte(symbolId);
        }
        
        public override void Deserialize(IReader reader)
        {
            presetId = reader.ReadSByte();
            symbolId = reader.ReadSByte();
        }
        
    }
    
}