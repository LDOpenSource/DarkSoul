

// Generated on 02/23/2017 16:53:29
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightHumanReadyStateMessage : NetworkMessage
    {
        public override ushort Id => 740;
        
        
        public double characterId;
        public bool isReady;
        
        public GameFightHumanReadyStateMessage()
        {
        }
        
        public GameFightHumanReadyStateMessage(double characterId, bool isReady)
        {
            this.characterId = characterId;
            this.isReady = isReady;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(characterId);
            writer.WriteBoolean(isReady);
        }
        
        public override void Deserialize(IReader reader)
        {
            characterId = reader.ReadVarUhLong();
            isReady = reader.ReadBoolean();
        }
        
    }
    
}