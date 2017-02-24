

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightTemporaryBoostEffect : AbstractFightDispellableEffect
    {
        public override short TypeId => 209;
        
        public short delta;
        
        public FightTemporaryBoostEffect()
        {
        }
        
        public FightTemporaryBoostEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, ushort spellId, uint effectId, uint parentBoostUid, short delta)
         : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid)
        {
            this.delta = delta;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(delta);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            delta = reader.ReadShort();
        }
        
    }
    
}