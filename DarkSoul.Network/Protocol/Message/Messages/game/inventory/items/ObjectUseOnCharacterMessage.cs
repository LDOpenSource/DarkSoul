

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
    public class ObjectUseOnCharacterMessage : ObjectUseMessage
    {
        public override ushort Id => 3003;
        
        
        public double characterId;
        
        public ObjectUseOnCharacterMessage()
        {
        }
        
        public ObjectUseOnCharacterMessage(uint objectUID, double characterId)
         : base(objectUID)
        {
            this.characterId = characterId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(characterId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            characterId = reader.ReadVarUhLong();
        }
        
    }
    
}