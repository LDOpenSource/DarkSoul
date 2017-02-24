

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightTemporarySpellBoostEffect : FightTemporaryBoostEffect
    {
        public override short TypeId => 207;
        
        public ushort boostedSpellId;
        
        public FightTemporarySpellBoostEffect()
        {
        }
        
        public FightTemporarySpellBoostEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, ushort spellId, uint effectId, uint parentBoostUid, short delta, ushort boostedSpellId)
         : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid, delta)
        {
            this.boostedSpellId = boostedSpellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)boostedSpellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            boostedSpellId = reader.ReadVarUhShort();
        }
        
    }
    
}