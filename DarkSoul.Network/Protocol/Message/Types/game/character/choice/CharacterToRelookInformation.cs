

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class CharacterToRelookInformation : AbstractCharacterToRefurbishInformation
    {
        public override short TypeId => 399;
        
        
        public CharacterToRelookInformation()
        {
        }
        
        public CharacterToRelookInformation(double id, IEnumerable<int> colors, uint cosmeticId)
         : base(id, colors, cosmeticId)
        {
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}