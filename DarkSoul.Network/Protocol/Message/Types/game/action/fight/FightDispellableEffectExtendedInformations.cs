

// Generated on 02/23/2017 18:06:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightDispellableEffectExtendedInformations
    {
        public virtual short TypeId => 208;
        
        public ushort actionId;
        public double sourceId;
        public Types.AbstractFightDispellableEffect effect;
        
        public FightDispellableEffectExtendedInformations()
        {
        }
        
        public FightDispellableEffectExtendedInformations(ushort actionId, double sourceId, Types.AbstractFightDispellableEffect effect)
        {
            this.actionId = actionId;
            this.sourceId = sourceId;
            this.effect = effect;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)actionId);
            writer.WriteDouble(sourceId);
            writer.WriteShort(effect.TypeId);
            effect.Serialize(writer);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            actionId = reader.ReadVarUhShort();
            sourceId = reader.ReadDouble();
            effect = ProtocolTypeManager.GetInstance<Types.AbstractFightDispellableEffect>(reader.ReadUShort());
            effect.Deserialize(reader);
        }
        
    }
    
}