

// Generated on 02/23/2017 16:53:18
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AbstractGameActionFightTargetedAbilityMessage : AbstractGameActionMessage
    {
        public override ushort Id => 6118;
        
        
        public bool silentCast;
        public bool verboseCast;
        public double targetId;
        public short destinationCellId;
        public sbyte critical;
        
        public AbstractGameActionFightTargetedAbilityMessage()
        {
        }
        
        public AbstractGameActionFightTargetedAbilityMessage(ushort actionId, double sourceId, bool silentCast, bool verboseCast, double targetId, short destinationCellId, sbyte critical)
         : base(actionId, sourceId)
        {
            this.silentCast = silentCast;
            this.verboseCast = verboseCast;
            this.targetId = targetId;
            this.destinationCellId = destinationCellId;
            this.critical = critical;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, silentCast);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, verboseCast);
            writer.WriteByte(flag1);
            writer.WriteDouble(targetId);
            writer.WriteShort(destinationCellId);
            writer.WriteSByte(critical);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            byte flag1 = reader.ReadByte();
            silentCast = BooleanByteWrapper.GetFlag(flag1, 0);
            verboseCast = BooleanByteWrapper.GetFlag(flag1, 1);
            targetId = reader.ReadDouble();
            destinationCellId = reader.ReadShort();
            critical = reader.ReadSByte();
        }
        
    }
    
}