

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class CharacterToRemodelInformations : CharacterRemodelingInformation
    {
        public override short TypeId => 477;
        
        public sbyte possibleChangeMask;
        public sbyte mandatoryChangeMask;
        
        public CharacterToRemodelInformations()
        {
        }
        
        public CharacterToRemodelInformations(double id, string name, sbyte breed, bool sex, ushort cosmeticId, IEnumerable<int> colors, sbyte possibleChangeMask, sbyte mandatoryChangeMask)
         : base(id, name, breed, sex, cosmeticId, colors)
        {
            this.possibleChangeMask = possibleChangeMask;
            this.mandatoryChangeMask = mandatoryChangeMask;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(possibleChangeMask);
            writer.WriteSByte(mandatoryChangeMask);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            possibleChangeMask = reader.ReadSByte();
            mandatoryChangeMask = reader.ReadSByte();
        }
        
    }
    
}