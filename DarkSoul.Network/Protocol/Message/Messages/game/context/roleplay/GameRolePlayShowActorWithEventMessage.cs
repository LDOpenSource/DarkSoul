

// Generated on 02/23/2017 16:53:33
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameRolePlayShowActorWithEventMessage : GameRolePlayShowActorMessage
    {
        public override ushort Id => 6407;
        
        
        public sbyte actorEventId;
        
        public GameRolePlayShowActorWithEventMessage()
        {
        }
        
        public GameRolePlayShowActorWithEventMessage(Types.GameRolePlayActorInformations informations, sbyte actorEventId)
         : base(informations)
        {
            this.actorEventId = actorEventId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(actorEventId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            actorEventId = reader.ReadSByte();
        }
        
    }
    
}