

// Generated on 02/23/2017 16:53:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SpellItemBoostMessage : NetworkMessage
    {
        public override ushort Id => 6011;
        
        
        public uint statId;
        public ushort spellId;
        public short value;
        
        public SpellItemBoostMessage()
        {
        }
        
        public SpellItemBoostMessage(uint statId, ushort spellId, short value)
        {
            this.statId = statId;
            this.spellId = spellId;
            this.value = value;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)statId);
            writer.WriteVarShort((int)spellId);
            writer.WriteVarShort((int)value);
        }
        
        public override void Deserialize(IReader reader)
        {
            statId = reader.ReadVarUhInt();
            spellId = reader.ReadVarUhShort();
            value = reader.ReadVarShort();
        }
        
    }
    
}