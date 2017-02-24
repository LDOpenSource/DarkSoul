

// Generated on 02/23/2017 16:53:32
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightShowFighterMessage : NetworkMessage
    {
        public override ushort Id => 5864;
        
        
        public Types.GameFightFighterInformations informations;
        
        public GameFightShowFighterMessage()
        {
        }
        
        public GameFightShowFighterMessage(Types.GameFightFighterInformations informations)
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
            informations = ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadUShort());
            informations.Deserialize(reader);
        }
        
    }
    
}