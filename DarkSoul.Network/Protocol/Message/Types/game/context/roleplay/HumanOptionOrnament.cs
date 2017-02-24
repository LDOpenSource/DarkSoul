

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HumanOptionOrnament : HumanOption
    {
        public override short TypeId => 411;
        
        public ushort ornamentId;
        
        public HumanOptionOrnament()
        {
        }
        
        public HumanOptionOrnament(ushort ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)ornamentId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            ornamentId = reader.ReadVarUhShort();
        }
        
    }
    
}