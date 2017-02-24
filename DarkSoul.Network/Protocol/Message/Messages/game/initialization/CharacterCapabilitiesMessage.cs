

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
    public class CharacterCapabilitiesMessage : NetworkMessage
    {
        public override ushort Id => 6339;
        
        
        public uint guildEmblemSymbolCategories;
        
        public CharacterCapabilitiesMessage()
        {
        }
        
        public CharacterCapabilitiesMessage(uint guildEmblemSymbolCategories)
        {
            this.guildEmblemSymbolCategories = guildEmblemSymbolCategories;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)guildEmblemSymbolCategories);
        }
        
        public override void Deserialize(IReader reader)
        {
            guildEmblemSymbolCategories = reader.ReadVarUhInt();
        }
        
    }
    
}