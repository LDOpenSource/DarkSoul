

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
    public class InviteInHavenBagOfferMessage : NetworkMessage
    {
        public override ushort Id => 6643;
        
        
        public Types.CharacterMinimalInformations hostInformations;
        public int timeLeftBeforeCancel;
        
        public InviteInHavenBagOfferMessage()
        {
        }
        
        public InviteInHavenBagOfferMessage(Types.CharacterMinimalInformations hostInformations, int timeLeftBeforeCancel)
        {
            this.hostInformations = hostInformations;
            this.timeLeftBeforeCancel = timeLeftBeforeCancel;
        }
        
        public override void Serialize(IWriter writer)
        {
            hostInformations.Serialize(writer);
            writer.WriteVarInt((int)timeLeftBeforeCancel);
        }
        
        public override void Deserialize(IReader reader)
        {
            hostInformations = new Types.CharacterMinimalInformations();
            hostInformations.Deserialize(reader);
            timeLeftBeforeCancel = reader.ReadVarInt();
        }
        
    }
    
}