

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
    public class SpellVariantActivationMessage : NetworkMessage
    {
        public override ushort Id => 6705;
        
        
        public bool result;
        public ushort activatedSpellId;
        public ushort deactivatedSpellId;
        
        public SpellVariantActivationMessage()
        {
        }
        
        public SpellVariantActivationMessage(bool result, ushort activatedSpellId, ushort deactivatedSpellId)
        {
            this.result = result;
            this.activatedSpellId = activatedSpellId;
            this.deactivatedSpellId = deactivatedSpellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(result);
            writer.WriteVarShort((int)activatedSpellId);
            writer.WriteVarShort((int)deactivatedSpellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            result = reader.ReadBoolean();
            activatedSpellId = reader.ReadVarUhShort();
            deactivatedSpellId = reader.ReadVarUhShort();
        }
        
    }
    
}