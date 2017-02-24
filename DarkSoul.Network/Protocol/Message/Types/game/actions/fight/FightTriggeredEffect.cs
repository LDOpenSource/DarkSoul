

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightTriggeredEffect : AbstractFightDispellableEffect
    {
        public override short TypeId => 210;
        
        public int arg1;
        public int arg2;
        public int arg3;
        public short delay;
        
        public FightTriggeredEffect()
        {
        }
        
        public FightTriggeredEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, ushort spellId, uint effectId, uint parentBoostUid, int arg1, int arg2, int arg3, short delay)
         : base(uid, targetId, turnDuration, dispelable, spellId, effectId, parentBoostUid)
        {
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.delay = delay;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(arg1);
            writer.WriteInt(arg2);
            writer.WriteInt(arg3);
            writer.WriteShort(delay);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            arg1 = reader.ReadInt();
            arg2 = reader.ReadInt();
            arg3 = reader.ReadInt();
            delay = reader.ReadShort();
        }
        
    }
    
}