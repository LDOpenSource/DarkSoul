

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AbstractFightDispellableEffect
    {
        public virtual short TypeId => 206;
        
        public uint uid;
        public double targetId;
        public short turnDuration;
        public sbyte dispelable;
        public ushort spellId;
        public uint effectId;
        public uint parentBoostUid;
        
        public AbstractFightDispellableEffect()
        {
        }
        
        public AbstractFightDispellableEffect(uint uid, double targetId, short turnDuration, sbyte dispelable, ushort spellId, uint effectId, uint parentBoostUid)
        {
            this.uid = uid;
            this.targetId = targetId;
            this.turnDuration = turnDuration;
            this.dispelable = dispelable;
            this.spellId = spellId;
            this.effectId = effectId;
            this.parentBoostUid = parentBoostUid;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)uid);
            writer.WriteDouble(targetId);
            writer.WriteShort(turnDuration);
            writer.WriteSByte(dispelable);
            writer.WriteVarShort((int)spellId);
            writer.WriteVarInt((int)effectId);
            writer.WriteVarInt((int)parentBoostUid);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            uid = reader.ReadVarUhInt();
            targetId = reader.ReadDouble();
            turnDuration = reader.ReadShort();
            dispelable = reader.ReadSByte();
            spellId = reader.ReadVarUhShort();
            effectId = reader.ReadVarUhInt();
            parentBoostUid = reader.ReadVarUhInt();
        }
        
    }
    
}