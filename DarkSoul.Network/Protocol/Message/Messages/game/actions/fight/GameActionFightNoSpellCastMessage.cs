

// Generated on 02/23/2017 16:53:19
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionFightNoSpellCastMessage : NetworkMessage
    {
        public override ushort Id => 6132;
        
        
        public uint spellLevelId;
        
        public GameActionFightNoSpellCastMessage()
        {
        }
        
        public GameActionFightNoSpellCastMessage(uint spellLevelId)
        {
            this.spellLevelId = spellLevelId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)spellLevelId);
        }
        
        public override void Deserialize(IReader reader)
        {
            spellLevelId = reader.ReadVarUhInt();
        }
        
    }
    
}