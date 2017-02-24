

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class TreasureHuntStepFollowDirectionToHint : TreasureHuntStep
    {
        public override short TypeId => 472;
        
        public sbyte direction;
        public ushort npcId;
        
        public TreasureHuntStepFollowDirectionToHint()
        {
        }
        
        public TreasureHuntStepFollowDirectionToHint(sbyte direction, ushort npcId)
        {
            this.direction = direction;
            this.npcId = npcId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(direction);
            writer.WriteVarShort((int)npcId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            direction = reader.ReadSByte();
            npcId = reader.ReadVarUhShort();
        }
        
    }
    
}