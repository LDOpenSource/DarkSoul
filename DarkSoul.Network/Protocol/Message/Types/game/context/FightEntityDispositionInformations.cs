

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightEntityDispositionInformations : EntityDispositionInformations
    {
        public override short TypeId => 217;
        
        public double carryingCharacterId;
        
        public FightEntityDispositionInformations()
        {
        }
        
        public FightEntityDispositionInformations(short cellId, sbyte direction, double carryingCharacterId)
         : base(cellId, direction)
        {
            this.carryingCharacterId = carryingCharacterId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(carryingCharacterId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            carryingCharacterId = reader.ReadDouble();
        }
        
    }
    
}