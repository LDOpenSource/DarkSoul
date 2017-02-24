

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
    public class CharacterNameSuggestionSuccessMessage : NetworkMessage
    {
        public override ushort Id => 5544;
        
        
        public string suggestion;
        
        public CharacterNameSuggestionSuccessMessage()
        {
        }
        
        public CharacterNameSuggestionSuccessMessage(string suggestion)
        {
            this.suggestion = suggestion;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(suggestion);
        }
        
        public override void Deserialize(IReader reader)
        {
            suggestion = reader.ReadUTF();
        }
        
    }
    
}