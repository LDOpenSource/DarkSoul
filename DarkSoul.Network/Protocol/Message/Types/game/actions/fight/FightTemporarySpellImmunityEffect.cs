

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightTemporarySpellImmunityEffect : AbstractFightDispellableEffect
    {
        public override short TypeId => 366;
        
        public int immuneSpellId;
        
        public FightTemporarySpellImmunityEffect()
        {
        }
        
        public FightTemporarySpellImmunityEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, ushort spellId, uint effectId, uint parentBoostUid, int immuneSpellId)
         : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid)
        {
            this.immuneSpellId = immuneSpellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(immuneSpellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            immuneSpellId = reader.ReadInt();
        }
        
    }
    
}