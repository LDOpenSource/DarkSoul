

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class TreasureHuntStepFollowDirection : TreasureHuntStep
    {
        public override short TypeId => 468;
        
        public sbyte direction;
        public ushort mapCount;
        
        public TreasureHuntStepFollowDirection()
        {
        }
        
        public TreasureHuntStepFollowDirection(sbyte direction, ushort mapCount)
        {
            this.direction = direction;
            this.mapCount = mapCount;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(direction);
            writer.WriteVarShort((int)mapCount);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            direction = reader.ReadSByte();
            mapCount = reader.ReadVarUhShort();
        }
        
    }
    
}