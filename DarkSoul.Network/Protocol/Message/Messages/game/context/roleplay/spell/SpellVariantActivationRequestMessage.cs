

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
    public class SpellVariantActivationRequestMessage : NetworkMessage
    {
        public override ushort Id => 6707;
        
        
        public ushort spellId;
        
        public SpellVariantActivationRequestMessage()
        {
        }
        
        public SpellVariantActivationRequestMessage(ushort spellId)
        {
            this.spellId = spellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)spellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            spellId = reader.ReadVarUhShort();
        }
        
    }
    
}