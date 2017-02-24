

// Generated on 02/23/2017 16:53:31
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightRefreshFighterMessage : NetworkMessage
    {
        public override ushort Id => 6309;
        
        
        public Types.GameContextActorInformations informations;
        
        public GameFightRefreshFighterMessage()
        {
        }
        
        public GameFightRefreshFighterMessage(Types.GameContextActorInformations informations)
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
            informations = ProtocolTypeManager.GetInstance<Types.GameContextActorInformations>(reader.ReadUShort());
            informations.Deserialize(reader);
        }
        
    }
    
}