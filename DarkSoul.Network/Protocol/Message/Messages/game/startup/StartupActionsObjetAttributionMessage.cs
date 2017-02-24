

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
    public class StartupActionsObjetAttributionMessage : NetworkMessage
    {
        public override ushort Id => 1303;
        
        
        public int actionId;
        public double characterId;
        
        public StartupActionsObjetAttributionMessage()
        {
        }
        
        public StartupActionsObjetAttributionMessage(int actionId, double characterId)
        {
            this.actionId = actionId;
            this.characterId = characterId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(actionId);
            writer.WriteVarLong(characterId);
        }
        
        public override void Deserialize(IReader reader)
        {
            actionId = reader.ReadInt();
            characterId = reader.ReadVarUhLong();
        }
        
    }
    
}