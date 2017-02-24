

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
    public class CharactersListMessage : BasicCharactersListMessage
    {
        public override ushort Id => 151;
        
        
        public bool hasStartupActions;
        
        public CharactersListMessage()
        {
        }
        
        public CharactersListMessage(IEnumerable<Types.CharacterBaseInformations> characters, bool hasStartupActions)
         : base(characters)
        {
            this.hasStartupActions = hasStartupActions;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(hasStartupActions);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            hasStartupActions = reader.ReadBoolean();
        }
        
    }
    
}