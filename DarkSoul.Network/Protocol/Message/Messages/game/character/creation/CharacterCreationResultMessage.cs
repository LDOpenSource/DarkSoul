

// Generated on 02/23/2017 16:53:25
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CharacterCreationResultMessage : NetworkMessage
    {
        public override ushort Id => 161;
        
        
        public sbyte result;
        
        public CharacterCreationResultMessage()
        {
        }
        
        public CharacterCreationResultMessage(sbyte result)
        {
            this.result = result;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(result);
        }
        
        public override void Deserialize(IReader reader)
        {
            result = reader.ReadSByte();
        }
        
    }
    
}