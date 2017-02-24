

// Generated on 02/23/2017 16:53:50
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SetCharacterRestrictionsMessage : NetworkMessage
    {
        public override ushort Id => 170;
        
        
        public double actorId;
        public Types.ActorRestrictionsInformations restrictions;
        
        public SetCharacterRestrictionsMessage()
        {
        }
        
        public SetCharacterRestrictionsMessage(double actorId, Types.ActorRestrictionsInformations restrictions)
        {
            this.actorId = actorId;
            this.restrictions = restrictions;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(actorId);
            restrictions.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            actorId = reader.ReadDouble();
            restrictions = new Types.ActorRestrictionsInformations();
            restrictions.Deserialize(reader);
        }
        
    }
    
}