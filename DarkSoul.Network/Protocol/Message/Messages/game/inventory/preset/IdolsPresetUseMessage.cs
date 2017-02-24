

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
    public class IdolsPresetUseMessage : NetworkMessage
    {
        public override ushort Id => 6615;
        
        
        public sbyte presetId;
        public bool party;
        
        public IdolsPresetUseMessage()
        {
        }
        
        public IdolsPresetUseMessage(sbyte presetId, bool party)
        {
            this.presetId = presetId;
            this.party = party;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(presetId);
            writer.WriteBoolean(party);
        }
        
        public override void Deserialize(IReader reader)
        {
            presetId = reader.ReadSByte();
            party = reader.ReadBoolean();
        }
        
    }
    
}