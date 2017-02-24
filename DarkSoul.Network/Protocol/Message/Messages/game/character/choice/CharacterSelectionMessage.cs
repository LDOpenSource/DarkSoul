

// Generated on 02/23/2017 16:53:25
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CharacterSelectionMessage : NetworkMessage
    {
        public override ushort Id => 152;
        
        
        public double id;
        
        public CharacterSelectionMessage()
        {
        }
        
        public CharacterSelectionMessage(double id)
        {
            this.id = id;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(id);
        }
        
        public override void Deserialize(IReader reader)
        {
            id = reader.ReadVarUhLong();
        }
        
    }
    
}