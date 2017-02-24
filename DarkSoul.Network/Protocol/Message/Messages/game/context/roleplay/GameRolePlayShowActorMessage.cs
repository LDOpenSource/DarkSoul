

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
    public class GameRolePlayShowActorMessage : NetworkMessage
    {
        public override ushort Id => 0x1600;
        
        
        public Types.GameRolePlayActorInformations informations;
        
        public GameRolePlayShowActorMessage()
        {
        }
        
        public GameRolePlayShowActorMessage(Types.GameRolePlayActorInformations informations)
        {
            this.informations = informations;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(informations.TypeId);
            informations.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            informations = ProtocolTypeManager.GetInstance<Types.GameRolePlayActorInformations>(reader.ReadUShort());
            informations.Deserialize(reader);
        }
        
    }
    
}