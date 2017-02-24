

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameFightSpellCooldown
    {
        public virtual short TypeId => 205;
        
        public int spellId;
        public sbyte cooldown;
        
        public GameFightSpellCooldown()
        {
        }
        
        public GameFightSpellCooldown(int spellId, sbyte cooldown)
        {
            this.spellId = spellId;
            this.cooldown = cooldown;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(spellId);
            writer.WriteSByte(cooldown);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            spellId = reader.ReadInt();
            cooldown = reader.ReadSByte();
        }
        
    }
    
}