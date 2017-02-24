

// Generated on 02/23/2017 16:53:24
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CharacterSelectedForceMessage : NetworkMessage
    {
        public override ushort Id => 6068;
        
        
        public int id;
        
        public CharacterSelectedForceMessage()
        {
        }
        
        public CharacterSelectedForceMessage(int id)
        {
            this.id = id;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(id);
        }
        
        public override void Deserialize(IReader reader)
        {
            id = reader.ReadInt();
        }
        
    }
    
}