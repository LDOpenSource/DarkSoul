

// Generated on 02/23/2017 16:53:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class InviteInHavenBagClosedMessage : NetworkMessage
    {
        public override ushort Id => 6645;
        
        
        public Types.CharacterMinimalInformations hostInformations;
        
        public InviteInHavenBagClosedMessage()
        {
        }
        
        public InviteInHavenBagClosedMessage(Types.CharacterMinimalInformations hostInformations)
        {
            this.hostInformations = hostInformations;
        }
        
        public override void Serialize(IWriter writer)
        {
            hostInformations.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            hostInformations = new Types.CharacterMinimalInformations();
            hostInformations.Deserialize(reader);
        }
        
    }
    
}