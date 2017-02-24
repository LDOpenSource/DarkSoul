

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class TreasureHuntStepFollowDirectionToPOI : TreasureHuntStep
    {
        public override short TypeId => 461;
        
        public sbyte direction;
        public ushort poiLabelId;
        
        public TreasureHuntStepFollowDirectionToPOI()
        {
        }
        
        public TreasureHuntStepFollowDirectionToPOI(sbyte direction, ushort poiLabelId)
        {
            this.direction = direction;
            this.poiLabelId = poiLabelId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(direction);
            writer.WriteVarShort((int)poiLabelId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            direction = reader.ReadSByte();
            poiLabelId = reader.ReadVarUhShort();
        }
        
    }
    
}