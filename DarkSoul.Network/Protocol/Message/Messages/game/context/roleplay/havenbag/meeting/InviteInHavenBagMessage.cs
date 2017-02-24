

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
    public class InviteInHavenBagMessage : NetworkMessage
    {
        public override ushort Id => 6642;
        
        
        public Types.CharacterMinimalInformations guestInformations;
        public bool accept;
        
        public InviteInHavenBagMessage()
        {
        }
        
        public InviteInHavenBagMessage(Types.CharacterMinimalInformations guestInformations, bool accept)
        {
            this.guestInformations = guestInformations;
            this.accept = accept;
        }
        
        public override void Serialize(IWriter writer)
        {
            guestInformations.Serialize(writer);
            writer.WriteBoolean(accept);
        }
        
        public override void Deserialize(IReader reader)
        {
            guestInformations = new Types.CharacterMinimalInformations();
            guestInformations.Deserialize(reader);
            accept = reader.ReadBoolean();
        }
        
    }
    
}