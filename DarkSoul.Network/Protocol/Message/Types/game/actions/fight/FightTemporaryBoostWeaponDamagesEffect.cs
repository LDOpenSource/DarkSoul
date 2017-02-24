

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightTemporaryBoostWeaponDamagesEffect : FightTemporaryBoostEffect
    {
        public override short TypeId => 211;
        
        public short weaponTypeId;
        
        public FightTemporaryBoostWeaponDamagesEffect()
        {
        }
        
        public FightTemporaryBoostWeaponDamagesEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, ushort spellId, uint effectId, uint parentBoostUid, short delta, short weaponTypeId)
         : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid, delta)
        {
            this.weaponTypeId = weaponTypeId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(weaponTypeId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            weaponTypeId = reader.ReadShort();
        }
        
    }
    
}