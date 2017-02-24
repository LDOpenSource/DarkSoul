

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightTemporaryBoostStateEffect : FightTemporaryBoostEffect
    {
        public override short TypeId => 214;
        
        public short stateId;
        
        public FightTemporaryBoostStateEffect()
        {
        }
        
        public FightTemporaryBoostStateEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, ushort spellId, uint effectId, uint parentBoostUid, short delta, short stateId)
         : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid, delta)
        {
            this.stateId = stateId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(stateId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            stateId = reader.ReadShort();
        }
        
    }
    
}