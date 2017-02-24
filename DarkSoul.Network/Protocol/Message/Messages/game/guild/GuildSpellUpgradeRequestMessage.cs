

// Generated on 02/23/2017 16:53:49
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildSpellUpgradeRequestMessage : NetworkMessage
    {
        public override ushort Id => 5699;
        
        
        public int spellId;
        
        public GuildSpellUpgradeRequestMessage()
        {
        }
        
        public GuildSpellUpgradeRequestMessage(int spellId)
        {
            this.spellId = spellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(spellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            spellId = reader.ReadInt();
        }
        
    }
    
}