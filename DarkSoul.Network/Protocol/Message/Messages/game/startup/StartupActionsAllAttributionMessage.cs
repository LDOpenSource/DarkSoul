

// Generated on 02/23/2017 16:54:03
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class StartupActionsAllAttributionMessage : NetworkMessage
    {
        public override ushort Id => 6537;
        
        
        public double characterId;
        
        public StartupActionsAllAttributionMessage()
        {
        }
        
        public StartupActionsAllAttributionMessage(double characterId)
        {
            this.characterId = characterId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(characterId);
        }
        
        public override void Deserialize(IReader reader)
        {
            characterId = reader.ReadVarUhLong();
        }
        
    }
    
}